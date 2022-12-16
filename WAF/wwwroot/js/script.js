const Http = new XMLHttpRequest();

const API_key = 'ec67be112d53ccd1ea96bd15d71174517740641a1c40843d776c36d9a179618f';

function myRequest(){
    const url='https://www.virustotal.com/vtapi/v2/url/report';
    const parameters = {'apikey': API_key, 'resource': 'https://www.facebook.com/'}
const options = {
    'method': 'Get',
    'Content-Type':'application/json',
    'Access-Control-Allow-Origin':'*',
};
fetch( 'https://www.virustotal.com/vtapi/v2/url/report?apikey=ec67be112d53ccd1ea96bd15d71174517740641a1c40843d776c36d9a179618f&resource=https://www.facebook.com/', {method:"GET",mode:"no-cors"} )
    .then( response => {
        // Do something with response.
        console.log(response);
    });
}