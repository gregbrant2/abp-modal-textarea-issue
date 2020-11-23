import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import {NgbModal, ModalDismissReasons} from '@ng-bootstrap/ng-bootstrap';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'basic-Moda';

  closeResult = ' ';
  formGroup: any;

  constructor(private modalService: NgbModal, private formBuilder: FormBuilder
    ) {
      this.formGroup = this.formBuilder.group({
        name: '',
        email: '',
        textarea: '',
        terms: false
      });
    }

  open(content: any) {
    this.modalService.open(content, {ariaLabelledBy: 'modal-basic-title'}).result.then((result: any) => {
      this.closeResult = `Closed with: ${result}`;
    }, (reason: any) => {
      this.closeResult = `Dismissed ${this.getDismissReason(reason)}`;
    });
  }
   
  onSubmit(formData: { [x: string]: any; }) {
    console.log('submitted');
    var name = formData['name'];
  }
  private getDismissReason(reason: any): string {
    if (reason === ModalDismissReasons.ESC) {
      return 'by pressing ESC';
    } else if (reason === ModalDismissReasons.BACKDROP_CLICK) {
      return 'by clicking on a backdrop';
    } else {
      return `with: ${reason}`;
    }
  }

}
