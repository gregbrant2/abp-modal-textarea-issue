import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'abpForm',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44364',
    redirectUri: baseUrl,
    clientId: 'abpForm_App',
    responseType: 'code',
    scope: 'offline_access abpForm',
  },
  apis: {
    default: {
      url: 'https://localhost:44364',
      rootNamespace: 'abpForm',
    },
  },
} as Config.Environment;
