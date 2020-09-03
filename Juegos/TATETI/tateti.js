let turno = 'X';
const vacio = '?';
function PonerXoY(boton) {
    //Poner la letra que correspona dependiendo de turno
    boton.value = turno;
} 
function ValidarQueEsteVacio(boton) {
    //Me dice si donde toco hay o no valor
    return (boton.value == vacio);
}
function CambiarDeTurno() {
    //Si es X pone Y sino, pone X
    if (turno == 'X')
        turno = 'O';
    else
        turno = 'X';
}
function ValidarTodosIgualesXY(btn1, btn2, btn3) {
    let btnA = document.getElementById(btn1).value;
    let btnB = document.getElementById(btn2).value;
    let btnC = document.getElementById(btn3).value;

    if (btnA == btnB && btnB == btnC && btnA != '?') {
        document.getElementById(btn1).style.background = 'red';
        return btnA;
    }
    return '';
}

function ValidarSiAlguienGano() {
    let forma = ValidarTodosIgualesXY('btn11', 'btn12', 'btn13');
    forma += ValidarTodosIgualesXY('btn21', 'btn22', 'btn23');
    forma += ValidarTodosIgualesXY('btn31', 'btn32', 'btn33');
    forma += ValidarTodosIgualesXY('btn11', 'btn21', 'btn31');
    forma += ValidarTodosIgualesXY('btn12', 'btn22', 'btn32');
    forma += ValidarTodosIgualesXY('btn13', 'btn23', 'btn33');
    forma += ValidarTodosIgualesXY('btn11', 'btn22', 'btn33');
    forma += ValidarTodosIgualesXY('btn13', 'btn22', 'btn31');
    return forma;
}
function Jugar(boton) {

    let quienganoAntesDeTocar = ValidarSiAlguienGano();
    if (quienganoAntesDeTocar != '')
        return;
    if (!ValidarQueEsteVacio(boton)) {
        alert('dale heramno toca en un ?!');
        return;
    }
    PonerXoY(boton);
    let quiengano = ValidarSiAlguienGano();
    if (quiengano == '')
        CambiarDeTurno();
    else {
        alert('Juego terminado, gano ' + quiengano);
        
    }
}