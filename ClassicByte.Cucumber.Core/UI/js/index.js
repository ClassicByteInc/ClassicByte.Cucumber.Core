function updateTime() {
    var now = new Date();
    var time = now.getHours() + ":" + now.getMinutes() + ":" + now.getSeconds();
    document.getElementById("time").innerHTML = time;
}

setInterval(updateTime, 1000);
