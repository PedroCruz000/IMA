const previousOperationText = document.querySelector("#previus-operation")
const currentOparationText = document.querySelector("#current-operation")
const buttons = document.querySelectorAll(".buttons button")

class Calculator{

}

buttons.forEach((btn) =>{

    btn.addEventListener("click", (e) =>{

        const value = e.target.innerText;
        
        console.log(value);
    })
});