const https = requere("https");

const chandeUser = "chandeLima"
const enveriment = {
    APIroute: "https://github.com/PedroCruz000",
};

const RequestRoute = `${API}/users/${user}`;

https.get(RequestRoute, (response) =>{
    console.log(response.statusCode);
});