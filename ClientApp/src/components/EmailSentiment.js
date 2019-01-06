import React, { Component } from 'react';
import './EmailSentiment.css';
import { Redirect } from 'react-router-dom';


export class EmailSentiment extends Component {

    constructor(props) {
        super(props);
        this.state = { emailList: [], loading: true, expanded: false, authRedirect: false, authLocation:'' };

        setInterval(() => {
            this.setState({ loading: true });
            fetch('api/EmailSentiment/LatestEmailSentimentAsync')
                .then(response => {
                    return response.json();
                })
                .then(data => {
                    this.setState({ emailList: data, loading: false});
                });

        }, 5000);
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
                        <th className='mailFrom'>From</th>
                        <th className='mailDate'>Date</th>
                        <th className='mailSubject'>Subject</th>
                        <th className='mailSentimentDescription'>Sentiment</th>
                        <th className={css + ' mailSentiment'}> Score</th>
                        <th className={css + ' mailKeyPhrase'}>Key phrases</th>
                        <th className={css + ' mailBody'}>Body</th>
                    </tr>
                </thead>
                <tbody>
                    {emailList.map(mail =>
                        <tr key={mail.analysedTimestampUtc} className={mail.sentimentCssClass}>
                            <td className='mailFrom'>{mail.fromAddresses}</td>
                            <td className='mailDate'>{mail.analysedTimestampAest}</td>
                            <td className='mailSubject'>{mail.subject}</td>
                            <td className='mailSentimentDescription'>{mail.sentimentDescription}</td>
                            <td className={css + ' mailSentiment'}>{mail.sentimentClassification}</td>
                            <td className={css + ' mailKeyPhrase'}><div className='limit-row-height'>{mail.sentimentKeyPhrases}</div></td>
                                <td className={css + ' mailBody'}><div className='limit-row-height'>{mail.sanitisedBody}</div></td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let tableContents = this.state.emailList.length === 0
            ? ''
            : EmailSentiment.renderEmailSentimentTable(this.state.emailList, this.state.expanded);
        let loadingContent = this.state.loading
            ? <div className='loading-progress'><img src='images/loading.gif' /><em>Loading...</em></div>
            : '';


        return (
            <div>
                <h1>Email Sentiment</h1>
                <p>This is the latest sentiment analysis of collected email.</p>
                <div className='interactive-content'>
                    <button onClick={this.onExpand}>Toggle Content Expansion</button>
                    {loadingContent}
                </div>

                {tableContents}
            </div>
        );
    }
}
