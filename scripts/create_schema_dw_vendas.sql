-- Gerado por Oracle SQL Developer Data Modeler 19.2.0.182.1216
--   em:        2021-09-27 10:37:53 BRT
--   site:      Oracle Database 11g
--   tipo:      Oracle Database 11g



CREATE TABLE dm_clientes (
    id_cliente       NUMBER(10) NOT NULL,
    nom_cli          VARCHAR2(40) NOT NULL,
    uf_cli           CHAR(2),
    cidade_cliente   VARCHAR2(50 BYTE)
);

ALTER TABLE dm_clientes ADD CONSTRAINT dm_clientes_pk PRIMARY KEY ( id_cliente );

CREATE TABLE dm_fornecedores (
    id_fornecedor       NUMBER(10) NOT NULL,
    nom_forn            VARCHAR2(40 BYTE) NOT NULL,
    uf_forn             CHAR(2 BYTE) NOT NULL,
    cidade_fornecedor   VARCHAR2(50 BYTE)
);

ALTER TABLE dm_fornecedores ADD CONSTRAINT dm_fornecedores_pk PRIMARY KEY ( id_fornecedor );

CREATE TABLE dm_produtos (
    id_produto       NUMBER(10) NOT NULL,
    classe_produto   CHAR(1 BYTE) NOT NULL,
    dsc_prod         VARCHAR2(40 BYTE) NOT NULL
);

ALTER TABLE dm_produtos ADD CONSTRAINT dm_produtos_pk PRIMARY KEY ( id_produto );

CREATE TABLE dm_tempo (
    id_tempo   NUMBER(10) NOT NULL,
    nu_ano     NUMBER(4),
    nu_mes     NUMBER(4),
    nu_dia     NUMBER(2)
);

ALTER TABLE dm_tempo ADD CONSTRAINT dm_tempo_pk PRIMARY KEY ( id_tempo );

CREATE TABLE dm_tipo_venda (
    id_tipo_venda   NUMBER NOT NULL,
    tipo_venda      CHAR(1 BYTE)
);

ALTER TABLE dm_tipo_venda ADD CONSTRAINT dm_tipo_venda_pk PRIMARY KEY ( id_tipo_venda );

CREATE TABLE ft_inadimplencia (
    id_tempo                   NUMBER(10) NOT NULL,
    id_cliente                 NUMBER(10) NOT NULL,
    total_vendido              NUMBER(10, 2) NOT NULL,
    valor_parcelas_atrasadas   NUMBER(10, 2) NOT NULL,
    qntd_parcelas_vencidas     NUMBER(4) NOT NULL
);

ALTER TABLE ft_inadimplencia ADD CONSTRAINT ft_inadimplencia_pk PRIMARY KEY ( id_tempo,
                                                                              id_cliente );

CREATE TABLE ft_vendas (
    id_tempo        NUMBER(10) NOT NULL,
    id_fornecedor   NUMBER(10) NOT NULL,
    id_produto      NUMBER(10) NOT NULL,
    id_tipo_venda   NUMBER NOT NULL,
    total_vendido   NUMBER(10, 2) NOT NULL
);

ALTER TABLE ft_vendas
    ADD CONSTRAINT ft_vendas_pk PRIMARY KEY ( id_tempo,
                                              id_produto,
                                              id_fornecedor,
                                              id_tipo_venda );

--  ERROR: FK name length exceeds maximum allowed length(30) 
ALTER TABLE ft_inadimplencia
    ADD CONSTRAINT ft_inadimplencia_dm_clientes_fk FOREIGN KEY ( id_cliente )
        REFERENCES dm_clientes ( id_cliente );

ALTER TABLE ft_inadimplencia
    ADD CONSTRAINT ft_inadimplencia_dm_tempo_fk FOREIGN KEY ( id_tempo )
        REFERENCES dm_tempo ( id_tempo );

ALTER TABLE ft_vendas
    ADD CONSTRAINT ft_vendas_dm_fornecedores_fk FOREIGN KEY ( id_fornecedor )
        REFERENCES dm_fornecedores ( id_fornecedor );

ALTER TABLE ft_vendas
    ADD CONSTRAINT ft_vendas_dm_produtos_fk FOREIGN KEY ( id_produto )
        REFERENCES dm_produtos ( id_produto );

ALTER TABLE ft_vendas
    ADD CONSTRAINT ft_vendas_dm_tempo_fk FOREIGN KEY ( id_tempo )
        REFERENCES dm_tempo ( id_tempo );

ALTER TABLE ft_vendas
    ADD CONSTRAINT ft_vendas_dm_tipo_venda_fk FOREIGN KEY ( id_tipo_venda )
        REFERENCES dm_tipo_venda ( id_tipo_venda );



-- Relatório do Resumo do Oracle SQL Developer Data Modeler: 
-- 
-- CREATE TABLE                             7
-- CREATE INDEX                             0
-- ALTER TABLE                             13
-- CREATE VIEW                              0
-- ALTER VIEW                               0
-- CREATE PACKAGE                           0
-- CREATE PACKAGE BODY                      0
-- CREATE PROCEDURE                         0
-- CREATE FUNCTION                          0
-- CREATE TRIGGER                           0
-- ALTER TRIGGER                            0
-- CREATE COLLECTION TYPE                   0
-- CREATE STRUCTURED TYPE                   0
-- CREATE STRUCTURED TYPE BODY              0
-- CREATE CLUSTER                           0
-- CREATE CONTEXT                           0
-- CREATE DATABASE                          0
-- CREATE DIMENSION                         0
-- CREATE DIRECTORY                         0
-- CREATE DISK GROUP                        0
-- CREATE ROLE                              0
-- CREATE ROLLBACK SEGMENT                  0
-- CREATE SEQUENCE                          0
-- CREATE MATERIALIZED VIEW                 0
-- CREATE MATERIALIZED VIEW LOG             0
-- CREATE SYNONYM                           0
-- CREATE TABLESPACE                        0
-- CREATE USER                              0
-- 
-- DROP TABLESPACE                          0
-- DROP DATABASE                            0
-- 
-- REDACTION POLICY                         0
-- 
-- ORDS DROP SCHEMA                         0
-- ORDS ENABLE SCHEMA                       0
-- ORDS ENABLE OBJECT                       0
-- 
-- ERRORS                                   1
-- WARNINGS                                 0
