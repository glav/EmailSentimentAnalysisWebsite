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
                    console.log('--> Response status: ' + response.status);
                    if (response.status === 302) {
                        console.log('--> Redirecting...');
                        this.setState({ authRedirect: true, authLocation: response.headers.get('Location') });
                    }
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
        if (this.state.authRedirect) {
            return <Redirect to="{this.state.authLocation}" />;
            //return <Redirect to="https://login.microsoftonline.com/413504eb-8622-47d2-aa72-ddbba4584471/oauth2/authorize?response_type=id_token&redirect_uri=https%3A%2F%2Femailsentiment-website-dev.azurewebsites.net%2F.auth%2Flogin%2Faad%2Fcallback&client_id=5daa5afb-f431-4847-99f9-5532a2f2f0c3&scope=openid+profile+email&response_mode=form_post&nonce=dd8d9d58e26248acb3a89f9f66874a17_20190106215339&state=redir%3D%252Fapi%252FEmailSentiment%252FLatestEmailSentimentAsync" />
        }

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
