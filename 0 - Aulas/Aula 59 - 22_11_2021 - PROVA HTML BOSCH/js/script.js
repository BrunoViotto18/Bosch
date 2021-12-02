function botaoClick(){
    let txt = formRestante.innerHTML
    let lastNum = parseInt(txt.charAt(txt.length-1))

    if (lastNum > 0){
        lastNum -= 1
        formRestante.innerHTML = `Vagas Disponiveis: ${lastNum}`

        if (lastNum == 0){
            formBotao.classList.toggle("form-botao-js")
        }
    }
    else{
        alert("As vagas esgotaram!")
    }
}

const formBotao = document.body.querySelector(".form-botao")
const formRestante = document.body.querySelector(".form-restante")

formBotao.addEventListener("click", () => {
    botaoClick()
})
