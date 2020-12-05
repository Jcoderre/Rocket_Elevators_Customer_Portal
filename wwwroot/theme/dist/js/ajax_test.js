


var batt_xhr = new XMLHttpRequest();
batt_xhr.onload = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(batt_xhr.responseText);
          document.getElementById('batterytest').innerHTML = parsedResponse[0];
          console.log(parsedResponse)
          console.log("Hello world")
  }
};
batt_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/battery/all');
batt_xhr.send();

var customer_xhr = new XMLHttpRequest();
customer_xhr.onload = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(customer_xhr.responseText);
          document.getElementById('Customertest').innerHTML = parsedResponse[0];
          console.log(parsedResponse)
          console.log("Hello world")
  }
};
customer_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/customer/all');
customer_xhr.send();

var elevator_xhr = new XMLHttpRequest();
elevator_xhr.onload = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(elevator_xhr.responseText);
          document.getElementById('elevatortest').innerHTML = parsedResponse.id;
          console.log(parsedResponse)
          console.log("Hello world")
  }
};
elevator_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/elevator/all');
elevator_xhr.send();

var column_xhr = new XMLHttpRequest();
column_xhr.onload = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(column_xhr.responseText);
          document.getElementById('columntest').innerHTML = parsedResponse[0];
          console.log(parsedResponse)
          console.log("Hello world")
  }
};
column_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/column/all');
column_xhr.send();

var building_xhr = new XMLHttpRequest();
building_xhr.onload = function() {
     if(this.readyState == 4 && this.status == 200){
          var parsedResponse = JSON.parse(building_xhr.responseText);
          document.getElementById('buildingtest').innerHTML = parsedResponse[0];
          console.log(parsedResponse)
          console.log("Hello world")
  }
};
building_xhr.open('GET', 'https://rocket-elevator-restapi.azurewebsites.net/api/building/all');
building_xhr.send();

