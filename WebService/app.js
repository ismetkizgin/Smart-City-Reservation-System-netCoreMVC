const sql = require('mysql');
const express = require('express');
const CompanyControl = require('./CompanyExpress');

var bodyParser = require('body-parser');

const PORT = 8000 || process.env.PORT;
const app = express();

app.use(bodyParser.json()); // support json encoded bodies
app.use(bodyParser.urlencoded({ extended: true })); // support encoded bodies

app.use(CompanyControl);

app.get("/", (req, res, next) => {
    res.send("Oldu");
})

app.use((req, res, next) => {
    res.send("404 NOT FOUND");
})
app.listen(PORT, ()=>{
    console.log("Yayinda : "+ PORT)
});