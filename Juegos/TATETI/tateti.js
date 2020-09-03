
function PonerXoY() {
    //Poner la letra que correspona dependiendo de turno
} 
function ValidarQueEsteVacio() {
    //Me dice si donde toco hay o no valor
}
function CambiarDeTurno() {
    //Si es X pone Y sino, pone X
}
function ValidarSiAlguienGano() {

}
function Jugar(carlos) {
    alert(carlos.getAttribute('fila'));
    //boton.value = 'X';
    if (!ValidarQueEsteVacio()) {
        alert('dale heramno toca en un ?!');
        return;
    }
    PonerXoY(carlos);
    ValidarSiAlguienGano();
    CambiarDeTurno();
}