#include <iostream>
#include <string>

using namespace std;

class Paciente {
private:
    string nombre;
    int edad;
    string cita;

public:
    void registrar() {
        cout << "Ingrese el nombre del paciente: ";
        cin.ignore();
        getline(cin, nombre);

        cout << "Ingrese la edad: ";
        cin >> edad;

        cout << "Ingrese la fecha de la cita: ";
        cin >> cita;
    }

    void mostrar() {
        cout << "\n--- DATOS DEL PACIENTE ---" << endl;
        cout << "Nombre: " << nombre << endl;
        cout << "Edad: " << edad << endl;
        cout << "Cita: " << cita << endl;
    }
};

int main() {

    Paciente paciente;
    int opcion;

    do {
        cout << "\n===== SISTEMA DE CLINICA =====" << endl;
        cout << "1. Registrar paciente" << endl;
        cout << "2. Mostrar paciente" << endl;
        cout << "3. Salir" << endl;
        cout << "Seleccione una opcion: ";
        cin >> opcion;

        switch(opcion) {

            case 1:
                paciente.registrar();
                break;

            case 2:
                paciente.mostrar();
                break;

            case 3:
                cout << "Saliendo del sistema..." << endl;
                break;

            default:
                cout << "Opcion invalida." << endl;
        }

    } while(opcion != 3);

    return 0;
}