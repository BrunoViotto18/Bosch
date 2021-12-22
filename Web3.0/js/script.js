$("document").ready(function(){
    $(".sumir-btn").click(function(){
        $("#paragrafo").hide();
    })

    $(".aparecer-btn").click(function(){
        $("#paragrafo").show();
    })
})

const subtrairButton = document.body.querySelector(".subtrair-btn")

let x = subtrairButton.innerHTML[-1]
subtrairButton.addEventListener("onclick", function(){
    console.log(x)
    if (x >= 0){
        subtrairButton.innerHTML = `Número: ${x}`
    }
    else{
        subtrairButton.style.backgroundColor = "#fff"
    }
})
