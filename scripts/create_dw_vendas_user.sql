create user dw_vendas
  identified by "dw_vendas"
  default tablespace DADOS_ACAD
  temporary tablespace TEMP_ACAD
  profile DEFAULT 
  quota unlimited on DADOS_ACAD
  quota unlimited on INDICES_ACAD;


grant connect to dw_vendas;
grant resource to dw_vendas;
grant create view to dw_vendas;