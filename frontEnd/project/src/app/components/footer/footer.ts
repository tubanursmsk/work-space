import { Component, ChangeDetectionStrategy, ChangeDetectorRef } from '@angular/core';
import { FormsModule } from "@angular/forms";
import { emailValid } from '../../utils/valids';
import { Api } from '../../services/api';

@Component({
  selector: 'app-footer',
  imports: [FormsModule],
  templateUrl: './footer.html',
  styleUrl: './footer.css',
  changeDetection: ChangeDetectionStrategy.Default
})
export class Footer {

  email = ''
  currentYear = 0
  error = ''
  success = ''

  constructor(private api: Api, private cdr: ChangeDetectorRef) {
    const date = new Date()
    this.currentYear = date.getFullYear()
  }

  fncEmailSend() {
    this.error = ''
    if (!emailValid(this.email)) {
      this.error = 'E-mail format fail'
    }else {
      this.api.newsletterControl(this.email).subscribe({
        next: (value) => {
          const arr = value as any[]
          if(arr.length == 0) {
            // kayıt yapabilir
            this.fncNewslatterAdd()
          }else {
            this.error = this.email + ' this email in use!'
          }
        },
        error: (error) => {
          this.error = 'Api Problem, Try Again!'
        },
        complete: () => {
          this.cdr.detectChanges()
        }
      })
    }
  }

  fncNewslatterAdd() {
    this.api.newslatterAdd(this.email).subscribe({
      next: (value) => {
        this.success = this.email + ' Added Success'
        setTimeout(() => {
          this.success = ''
          this.email = ''
          this.cdr.detectChanges()
        }, 3000);
      },
      error: (error) => {
        this.error = 'Api Problem, Try Again!'
      },
      complete: () => {
        this.cdr.detectChanges()
      }
    })
  }

}
