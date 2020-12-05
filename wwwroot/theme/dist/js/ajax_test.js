
// ------------- GET SECTION -------------- //
// ----- BATTERY ----- //
var batt_xhr = new XMLHttpRequest();
batt_xhr.onreadystatechange = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(batt_xhr.responseText);
          var battery_result = "";
          for(var i in parsedResponse){
               battery_result += "<tr>";
               battery_result += "<td>" + "ID: " + parsedResponse[i].id + "</td><br>";
               battery_result += "<td>" + " Building ID: " + parsedResponse[i].building_Id + "</td><br>";
               battery_result += "<td>" + " Employee ID: " + parsedResponse[i].employee_Id + "</td><br>";
               battery_result += "<td>" + " Customer ID: " + parsedResponse[i].customer_Id + "</td><br>";
               battery_result += "<td>" + " Status: " + parsedResponse[i].status + "</td><br>";
               battery_result += "<td>" + " Date of Commissioning: " + parsedResponse[i].commissioningDate + "</td><br>";
               battery_result += "<td>" + " Date of Last Inspection: " + parsedResponse[i].lastInspectionDate + "</td><br>";
               battery_result += "<td>" + " Certificate of Operation: " + parsedResponse[i].operationsCertificate + "</td><br>";
               battery_result += "<td>" + " Information: " + parsedResponse[i].information + "</td><br>";
               battery_result += "<td>" + " Notes: " + parsedResponse[i].notes + "</td></tr><br>";
               battery_result += "<td>" + "--------------------------------------------------" + "</td><br>"
          }
          document.getElementById('batterytest').innerHTML = battery_result;
     }
};
batt_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/battery/all');
batt_xhr.send();


// ---- CUSTOMER ----//
var customer_xhr = new XMLHttpRequest();
customer_xhr.onreadystatechange = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(customer_xhr.responseText);
          var customer_result = "";
          for(var i in parsedResponse){
               customer_result += "<tr>";
               customer_result += "<td>" + "ID: " + parsedResponse[i].id + "</td><br>";
               customer_result += "<td>" + " Customer Creation Date: " + parsedResponse[i].customerCreationDate + "</td><br>";
               customer_result += "<td>" + " Company Name: " + parsedResponse[i].companyName + "</td><br>";
               customer_result += "<td>" + " Headquarter Address: " + parsedResponse[i].companyHQAddress + "</td><br>";
               customer_result += "<td>" + " Contact Name: " + parsedResponse[i].nameCompanyContact + "</td><br>";
               customer_result += "<td>" + " Contact Phone: " + parsedResponse[i].phoneCompanyContact + "</td><br>";
               customer_result += "<td>" + " Contact Email: " + parsedResponse[i].emailCompanyContact + "</td><br>";
               customer_result += "<td>" + " Description: " + parsedResponse[i].companyDesc + "</td><br>";
               customer_result += "<td>" + " Tech Authority Name: " + parsedResponse[i].serviceTechName + "</td><br>";
               customer_result += "<td>" + " Tech Authority Phone: " + parsedResponse[i].techAuthorityPhone + "</td><br>";
               customer_result += "<td>" + " Tech Authority Email: " + parsedResponse[i].techMngrEmail + "</td></tr><br>";
               customer_result += "<td>" + "--------------------------------------------------" + "</td><br>"
          }
          document.getElementById('Customertest').innerHTML = customer_result;
     }
};
customer_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/customer/all');
customer_xhr.send();




// -----  Elevator --- //
var elevator_xhr = new XMLHttpRequest();
elevator_xhr.onreadystatechange = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(elevator_xhr.responseText);
          var elevator_result = "";
          for(var i in parsedResponse){
               elevator_result += "<tr>";
               elevator_result += "<td>" + "ID: " + parsedResponse[i].id + "</td><br>";
               elevator_result += "<td>" + " Column ID: " + parsedResponse[i].column_Id + "</td><br>";
               elevator_result += "<td>" + " Customer ID: " + parsedResponse[i].customer_Id + "</td><br>";
               elevator_result += "<td>" + " Status: " + parsedResponse[i].status + "</td><br>";
               elevator_result += "<td>" + " Serial Number: " + parsedResponse[i].serialNumber + "</td><br>";
               elevator_result += "<td>" + " Building Type: " + parsedResponse[i].buildingType + "</td><br>";
               elevator_result += "<td>" + " Date of Commissioning: " + parsedResponse[i].commissioningDate + "</td><br>";
               elevator_result += "<td>" + " Date of Last Inspection: " + parsedResponse[i].lastInspectionDate + "</td><br>";
               elevator_result += "<td>" + " Inspection Certificate: " + parsedResponse[i].inspectionCertificate + "</td>><br>";
               elevator_result += "<td>" + " Information: " + parsedResponse[i].information + "</td><br>";
               elevator_result += "<td>" + " Notes: " + parsedResponse[i].notes + "</td></tr><br>";
               elevator_result += "<td>" + "--------------------------------------------------" + "</td><br>"
          }
          document.getElementById('elevatortest').innerHTML = elevator_result;
     }
};
elevator_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/elevator/all');
elevator_xhr.send();




// --- Column ---- //
var column_xhr = new XMLHttpRequest();
column_xhr.onreadystatechange = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(column_xhr.responseText);
          var column_result = "";
          for(var i in parsedResponse){
               column_result += "<tr>";
               column_result += "<td>" + "ID: " + parsedResponse[i].id + "</td><br>";
               column_result += "<td>" + " Battery ID: " + parsedResponse[i].battery_Id + "</td><br>";
               column_result += "<td>" + " Customer ID: " + parsedResponse[i].customer_Id + "</td><br>";
               column_result += "<td>" + " Building Type: " + parsedResponse[i].buildingType + "</td><br>";
               column_result += "<td>" + " Number of Floor: " + parsedResponse[i].numFloors + "</td><br>";
               column_result += "<td>" + " Status: " + parsedResponse[i].status + "</td><br>";
               column_result += "<td>" + " Notes: " + parsedResponse[i].notes + "</td></tr><br>";
               column_result += "<td>" + "--------------------------------------------------" + "</td><br>"
          }
          document.getElementById('columntest').innerHTML = column_result;
     }
};
column_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/column/all');
column_xhr.send();





/// -----  BUILDING ------- ///
var building_xhr = new XMLHttpRequest();
building_xhr.onreadystatechange = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(building_xhr.responseText);
          var building_result = "";
          for(var i in parsedResponse){
               building_result += "<tr>";
               building_result += "<td>" + "ID: " + parsedResponse[i].id + "</td><br>";
               building_result += "<td>" + " Customer ID: " + parsedResponse[i].customer_Id + "</td><br>";
               building_result += "<td>" + " Building ID: " + parsedResponse[i].address_Id + "</td><br>";
               building_result += "<td>" + " Contact Email: " + parsedResponse[i].administratorEmail + "</td><br>";
               building_result += "<td>" + " Contact Phone Number: " + parsedResponse[i].administratorPhone + "</td><br>";
               building_result += "<td>" + " Technical Authority Name: " + parsedResponse[i].technicalContactFullName + "</td><br>";
               building_result += "<td>" + " Technical Authority Phone: " + parsedResponse[i].technicalContactPhone + "</td><br>";
               building_result += "<td>" + " Technical Authority Email: " + parsedResponse[i].technicalContactEmail + "</td></tr><br>";
               building_result += "<td>" + "--------------------------------------------------" + "</td><br>"
          }
          document.getElementById('buildingtest').innerHTML = building_result;

     }
};
building_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/building/all');
building_xhr.send();
