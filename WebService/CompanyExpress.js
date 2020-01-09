const mysql = require('mysql');
const express = require('express');
const router = express();
const sqlConfig = require("./Database/connection");

router.get("/CompanyControlTax", (req, res) => {
  var companyTaxNo = req.query.TaxNo;
  var companyName = req.query.Name;
  console.log('Şirket adı : ' + companyName, '\n TaxNO : ' + companyTaxNo);
  var str = "SELECT CompanyType FROM ControlTable where CompanyTaxNo= ? and CompanyName= ?";
  //console.log(str);
  var con = mysql.createConnection(sqlConfig);
  con.connect(function (err) {
    if (err) throw err;
    con.query(str, [companyTaxNo, companyName], function (err, result, fields) {
      if (err) throw err;
      console.log(result);
      res.send(result);
    });
  });
});

module.exports = router;