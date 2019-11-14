function addPoint(x, y) {
    if (!context) return
    context.lineTo(x - element.offsetLeft ,y - element.offsetTop)
    context.stroke()
}

var context
var element

function startDrawing(x, y) {
    element = document.getElementById("drawCanvas")
    context = element.getContext("2d")
    
    // context.beginPath()
    // context.strokeStyle('red')
    // context.lineWidth = 2
    context.beginPath();
    context.moveTo(x - element.offsetLeft ,y - element.offsetTop)
    context.strokeStyle = 'blue'
}

function endDrawing() {
    
    console.log('end')
}