import Swal from "sweetalert2";

export class ErrorService{
    static handleSwalError(error : any){
        const errorMessage = error && error.error ? error.error : 'An error occurred while adding items to the shopper list.';
        Swal.fire('Error', errorMessage, 'error');
    }
}