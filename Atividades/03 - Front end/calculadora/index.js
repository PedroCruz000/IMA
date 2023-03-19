const previousOperationText = document.querySelector("#previus-operation")
const currentOparationText = document.querySelector("#current-operation")
const buttons = document.querySelectorAll(".buttons button")

//objeto
class Calculator{
    constructor(previousOperationText,currentOparationText){
        this.previousOperationText = previousOperationText
        this.currentOparationText = currentOparationText
        this.currentOparation = ""
    }


    //metodo para pegar o que o usuario esta digitando 
    addDigit(digit){

        //validando se ja existe uma virgula na operação para que não haja mais que um ponto.
        if(digit === "," && this.currentOparationText.innerText.includes(",")){
            return;
        }

        // adicionando o digito no visor 
        this.currentOparation = digit
        this.updateScreen()
        
    }
   
    // adicionando operações 
    addOperations(operation){
       let operationValue;
       let previus = +this.previousOperationText.innerText;
       let curret = +this.currentOparationText.innerText;
       
    }

    // atualizar o visor 
    updateScreen(){
        this.currentOparationText.innerText += this.currentOparation;
    }

}





// metodos
const calc = new Calculator(previousOperationText, currentOparationText);


buttons.forEach((btn) =>{

    btn.addEventListener("click", (e) =>{

        const value = e.target.innerText;
        
        if(+value >= 0 || value === ","){
            calc.addDigit(value)
        }else{
            calc.addOperations(value)
        }
        
    })
});