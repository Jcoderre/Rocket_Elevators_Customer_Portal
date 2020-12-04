var xhr = new XMLHttpRequest();
   xhr.onreadystatechange = function() {
        var parsedResponse = JSON.parse(xhr.responseText);
        document.getElementById('test').innerHTML = parsedResponse[1].author;
   };
   xhr.open('GET', "https://rocket-elevator-restapi.azurewebsites.net/api/customer/all");
   xhr.send();