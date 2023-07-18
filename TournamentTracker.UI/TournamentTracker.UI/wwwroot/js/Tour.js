// Create SignalR connection
var connection = new signalR.HubConnectionBuilder()
    .withUrl("/notifyHub")
    .build();

// Handle received new tournament event
connection.on("NewTournamentReceived", function (newTournament) {
    // Perform actions when a new tournament is received
    console.log("New tournament received:", newTournament);
    // Update UI, display a notification, or perform any other necessary actions
});

// Start the SignalR connection
connection.start()
    .then(function () {
        console.log("SignalR connection established.");
    })
    .catch(function (err) {
        console.error(err.toString());
    });

// Function to send data to the server
function sendWebSocketData(eventName, payload) {
    var data = {
        eventName: eventName,
        payload: payload
    };
    connection.invoke(eventName, data)
        .catch(function (err) {
            console.error(err.toString());
        });
}

// Example usage to send data to the server
document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;
    var dataToSend = {
        user: user,
        message: message
    };
    sendWebSocketData("SendMessage", dataToSend);
    event.preventDefault();
});
