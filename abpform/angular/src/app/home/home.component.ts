import { AuthService } from '@abp/ng.core';
import { Component } from '@angular/core';
import { OAuthService } from 'angular-oauth2-oidc';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  get hasLoggedIn(): boolean {
    return this.oAuthService.hasValidAccessToken();
  }

  title = 'Abp form';
  formGroup: FormGroup;
  modalForm: FormGroup;

  isModalBusy = false;
  isModalOpen = false;

  constructor(
    private oAuthService: OAuthService,
    private authService: AuthService,
    private formBuilder: FormBuilder
  ) {
    this.formGroup = this.formBuilder.group({
      name: '',
      email: '',
      terms: false,
    });

    this.modalForm = this.formBuilder.group({
      someValue: '',
    });
  }

  onSubmit(formData) {
    console.log('submitted');
    var name = formData['name'];
  }

  submitModalForm() {
    console.log('Modal form submitted');
    console.log(this.modalForm.value);
  }

  login() {
    this.authService.initLogin();
  }
}
