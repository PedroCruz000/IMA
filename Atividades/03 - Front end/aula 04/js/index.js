funcionarios = document.querySelectorAll("funcionarios");
const atualizar = document


function calculaSalarioLiquido(funcionario){
    let{ salarioBruto: bruto, 
        imposto,
         analiseDesempenho: aumento} = funcionario;

         const parcial = bruto - imposto;
         const aumento = 1 + porcentagem
         
    return ( bruto - imposto );
}

function updateLinhasTabela(){

    for( let element of funcionarios){
        funcionario:{
            salarioBruto: parseFloat(
                element.querySelector("funcionario-campo-salario-bruto").textContent
            );
            salarioLiquido: parseFloat(
                element.querySelector("funcionario-compo-imposto").textContent
            )
            analiseDesempenho: parseFloat(
                element.querySelector("funcionario-campo-AD").textContent/100
            )
    
        }
    
        salarioLiquido = document.createElement("td")
        salarioLiquidoChild.classList.add("funcionarios-campo-salario-liquido")
        salarioLiquidoChild.textContent = calculaSalarioLiquido(funcionarios);
    
        row.appendChild(salarioLiquidoChild);
    }
}



atualizarBtn.addEventListener("click", (event) =>{
    event.preventDefout();
    atualizarLinhasTabela();
} )