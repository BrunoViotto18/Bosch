function aumentarTamanho(){
    document.getElementById('inputbusca').style.width="200px"
    document.getElementById('inputbusca').style.backgroundColor="#999999"
}

function voltarTamanho(){
    document.getElementById('inputbusca').style.width="57px"
    document.getElementById('inputbusca').style.backgroundColor="#fff"
}


const menu = document.body.querySelector(".menu")
const burger1 = document.body.querySelector("#burger1")
const burger2 = document.body.querySelector("#burger2")
const burger3 = document.body.querySelector("#burger3")
const menuBar = document.body.querySelector(".menu-bar")
const inputbusca = document.body.querySelector(".inputbusca")
const maisDetalhesBosch = document.body.querySelector(".nota-bosch")

//MenuBar
menu.addEventListener('click', () => {
    menuBar.classList.toggle("menu-bar-js")
    burger1.classList.toggle("burger1-js")
    burger2.classList.toggle("burger2-js")
    burger3.classList.toggle("burger3-js")
})

function openModal(mn) {
    let modal = document.getElementById(mn);

    if (typeof modal == 'undefined' || modal === null)
        return;

    modal.style.display = 'Block';
    document.body.style.overflow = 'hidden';
}

function closeModal(mn) {
    let modal = document.getElementById(mn);

    if (typeof modal == 'undefined' || modal === null)
        return;

    modal.style.display = 'none';
    document.body.style.overflow = 'auto';
}

function openModalsenai(mn) {
    let modal = document.getElementById(mn);

    if (typeof modal == 'undefined' || modal === null)
        return;

    modal.style.display = 'Block';
    document.body.style.overflow = 'hidden';
}

function closeModalsenai(mn) {
    let modal = document.getElementById(mn);

    if (typeof modal == 'undefined' || modal === null)
        return;

    modal.style.display = 'none';
    document.body.style.overflow = 'auto';
}

