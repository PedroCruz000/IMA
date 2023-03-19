let body = document.querySelector("#test");

function showSample (msg, content){
    body.innerText += `${msg}: \n  `
    body.innerText += `sample: ${content} \n \n`
}

let building = ["car" , "house", "door"];
let building2 = ["stairs" , "garage"]
let building3 = ["car" , "gym"]

showSample("original" , building)

building.shift();
showSample("shift", building)

//adiciona um valor a lista 
building.push("pool");

building.pop();

building.shift();




//remove um valor da lista 
building.unshift("car");

body.innerText = building


//juntar todas as buldings 

let allOfBuilding = building.concat (building2, building3)


//adicionar mais elementos ( abrindo espaço)
allOfBuilding.splice(1,0,"gate")


//corte
let newArr = allOfBuilding.slice(1 , 4)

//escrever na tela 
body.innerText = allOfBuilding;

//escrever na tela com o corete 

body.innerText = newArr