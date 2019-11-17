function drawPoint(x, y) {
    if (!context) return
    console.log('draw called!')
    var point = translatePoint(x,y)
    console.log(point)
    addPoint(point.x,point.y)
}

function addPoint(x,y) {    
    context.lineTo(x,y)
    context.stroke()
}

var context
var element

function startDrawing() {
    element = document.getElementById("drawCanvas")
    context = element.getContext("2d")
    context.strokeStyle = 'blue'
    context.beginPath()
    context.moveTo(0, 0)
    console.log("Started!")
}

function translatePoint(x, y) {
    var point = {
        x: x - element.offsetLeft,
        y: y - element.offsetTop
    }
    console.log(point)
    return point
}

function endDrawing() {
    
    console.log('end')
}