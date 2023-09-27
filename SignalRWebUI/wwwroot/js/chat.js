var connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:7186/SignalRHub").build();
document.getElementById("sendbutton").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var currentTime = new Date();
    var currentHour = currentTime.getHours();
    var currentMinute = currentTime.getMinutes();

    var li = document.createElement("li");
    var span = document.createElement("span");
    span.style.fontWeight = "bold";
    span.textContent = user;
    li.appendChild(span);
    li.innerHTML += ` :${message} - ${currentHour}:${currentMinute}`;
    document.getElementById("messagelist").appendChild(li);
});

connection.start().then(function () {
    document.getElementById("sendbutton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendbutton").addEventListener("click", function (event) {
    var user = document.getElementById("userinput").value;
    var message = document.getElementById("messageinput").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});