import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44364/',
  redirectUri: baseUrl,
  clientId: 'Doohlink_App',
  responseType: 'code',
  scope: 'offline_access Doohlink',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'Doohlink',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44389',
      rootNamespace: 'Doohlink',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
