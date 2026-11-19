import { Component, OnInit, inject, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { ApiService } from './core/api.service';

@Component({
  imports: [RouterOutlet],
  selector: 'app-root',
  template: `
    <main>
      <h1>EducationCentre (Angular)</h1>
      <p>API status: {{ status() }}</p>
    </main>
    <router-outlet />
  `,
})
export class App implements OnInit {
  private readonly api = inject(ApiService);
  protected readonly status = signal('checking...');

  ngOnInit(): void {
    this.api.getHealth().subscribe({
      next: (result) => this.status.set(result.status),
      error: () => this.status.set('unreachable'),
    });
  }
}
