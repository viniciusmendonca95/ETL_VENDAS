create user vendas
  identified by "vendas"
  default tablespace DADOS_ACAD
  temporary tablespace TEMP_ACAD
  profile DEFAULT 
  quota unlimited on DADOS_ACAD
  quota unlimited on INDICES_ACAD;


grant connect to vendas;
grant resource to vendas;
grant create view to vendas;