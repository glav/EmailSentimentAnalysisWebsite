import React, { Component } from 'react';
import './EmailSentiment.css';

export class EmailSentiment extends Component {

    constructor(props) {
        super(props);
        this.state = { emailList: [], loading: true, expanded: false };

        fetch('api/EmailSentiment/LatestEmailSentimentAsync')
            .then(response => response.json())
            .then(data => {
                this.setState({ emailList: data, loading: false, expanded: false });
            });
        this.onExpand = this.onExpand.bind(this);
    }

    onExpand() {
        this.setState({ expanded: !this.state.expanded });
    }

    static renderEmailSentimentTable(emailList, expanded) {
        let css = expanded ? 'showDetail' : 'collapse';
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>From</th>
                        <th>Score</th>
                        <th>Subject</th>
                        <th className={css}>Key phrases</th>
                        <th className={css}>Body</th>
                    </tr>
                </thead>
                <tbody>
                    {emailList.map(mail =>
                        <tr key={mail.analysedTimestampUtc} className={mail.sentimentCssClass}>
                            <td>{mail.fromAddresses}</td>
                            <td className="mailSentiment">{mail.sentimentClassification}</td>
                            <td><div className='trow'>{mail.subject}</div></td>
                            <td className={css}><div className='trow'>{mail.sentimentKeyPhrases}</div></td>
                            <td className={css}><div className='trow'>{mail.sanitisedBody}</div></td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : EmailSentiment.renderEmailSentimentTable(this.state.emailList, this.state.expanded);

        return (
            <div>
                <h1>Email Sentiment</h1>
                <p>This is the latest sentiment analysis of collected email.</p>
                <div>
                    <button onClick={this.onExpand}>Toggle Content Expansion</button>
                </div>

                {contents}
            </div>
        );
    }
}
