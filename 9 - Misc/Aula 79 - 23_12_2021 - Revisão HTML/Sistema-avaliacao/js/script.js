function fazerLogin(){
  // usuarios
  const alu_login = ["Alexandre", "Alison", "Allan", "Bruno", "Carlos", "Gabriel", "João", "Leonardo", "Luis", "Marina", "Melissa", "Murilo", "Nathan", "Nicholas", "Raissa", "Steicy", "Thiago", "Vinicius"];
  const prof_login = ["Edjalma","Vinicius"];
  // senhas
  const alu_senhas = ["an2002", "ao2002", "ak2000", "bv2003", "cc2004", "gb2003", "jc2001", "lv2002", "lb2003", "mb2002", "mm2002", "mp2003", "nc2003", "nv2002", "rg2003", "ss2002", "tp2001", "vg2002"];
  const prof_senhas = ["1234","1234"];
  
  var isRegistered = false;

  //pagando o valor digitado e separando em usuario e senha
  var login_user = document.querySelectorAll(".login-field");
  var usuario = login_user[0].value;
  var senha = login_user[1].value;
  
//loop para verificar o usuario
  for(var i = 0; i<18; i++){
    if(alu_login[i]==usuario && alu_senhas[i]==senha){
      window.location='../paginas/aluno.html';
      isRegistered = true;
      break;
    }
    else if(prof_login[i]==usuario && prof_senhas[i]==senha){
      window.location='../paginas/professor.html';
      isRegistered = true;
      break;
    }
    
  }
  if(!(isRegistered)){
    alert("Login inválido");
  }
}



// Votacao

$(function (){
  var star = '.star',
      selected = '.selected',
      unselected = '.unselected';



  
  $(star).click(function(){

    $(this).parent().find("*").each(function(){
      $(this).removeClass('selected')
    })

    $(this).addClass('selected');

  });

});

/*
$(selected).each(function(){
      $(this).removeClass('selected');
    });
*/