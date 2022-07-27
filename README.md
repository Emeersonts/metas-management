## metas-system-management

PO: dilceu.lewi@gerdau.com.br

Platform: openshift

Language: dotnet

CostCenter: 7406001015

Developer Partner: Stefanini

---

### Endpoints Stability:

**Please**, configure these following endpoints for stability and then inform devops team so they can proper configure the deployment config of your project 

Both liveness & readiness probes are used to control the health of an application. Failing liveness probe will restart the container, whereas failing readiness probe will stop our application from serving traffic.

*Liveness = /healthy/live*

Liveness probe checks the container health and if, for some reason, the liveness probe fails, it restarts the container. Reponse should be 200 family

*Readness = /healthy/ready*

In some cases we would like our application to be alive, but not serve traffic unless some conditions are met e.g, populating a dataset, waiting for some other service to be alive etc. In such cases we use readiness probe. If the condition inside readiness probe passes, only then our application can serve traffic.

 
### API Documentation

API Documention should be placed as follows:

```src/main/resources/META-INF/openapi.yml```

---
## More about your repository

### [Gitflow*](https://gerdau.atlassian.net/wiki/spaces/GAT/pages/1956773901/Gitflow)

### [Pipelines*](https://gerdau.atlassian.net/wiki/spaces/GAT/pages/2968191011/Pipelines)


---
***Requesting access to Confluence**

[Service Now > Digital Desk > Acesso a Grupos do AD](https://gerdau.service-now.com/digitaldesk?id=sc_cat_item&sys_id=84b96fcfdbe60090464f6390149619a8) > Tipo de Solicitação: Acesso a Sistemas - Grupos AD > Selecione o sistema: Atlassian Cloud > Grupo no AD > Confluence - Usuários
