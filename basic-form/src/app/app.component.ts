import { Component } from '@angular/core';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'basic-form';
  
  formGroup;

  constructor(
    private formBuilder: FormBuilder
  ) {
    this.formGroup = this.formBuilder.group({
      name: '',
      email: '',
      textarea: '',
      terms: false
    });
  }

  onSubmit(formData: { [x: string]: any; }) {
    console.log("submitted");
    var name = formData['name'];
  }
}
