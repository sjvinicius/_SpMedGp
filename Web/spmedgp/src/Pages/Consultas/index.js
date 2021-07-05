
import React, {useEffect, useState} from 'react'
import api from '../../services/api'

import Header from '../../Components/Header'
import Footer from '../../Components/Footer'

import { Container, Wrapper, Lista, BackConsult, Consult, TopConsult, InfoMed, Tittle, NomeMed, SubTittle, BodyConsult, Desc  } from './styles'



export default function Consultas(){
    const [listaCons, setListaCons ] = useState([]);

    async function BuscarCons() {
        
        const resposta = await api('/consultum')
        const data = await resposta.data
        setListaCons(data)
    }
    
    useEffect( () => {
        BuscarCons();
        
    },[])

    
    
    return(
        <>
            <Container>
                <Header />
                    <Wrapper>
                        
                        <Lista>
                            { 
                                listaCons.map( consulta => (

                                    <BackConsult>
                                            <Consult>
                                                <TopConsult>
                                                    <InfoMed>
                                                        <Tittle> {consulta.idMedicoNavigation.idEspecialidadeNavigation.tituloEspecialidade} </Tittle>
                                                        <NomeMed> {consulta.idMedicoNavigation.nome} </NomeMed>
                                                    </InfoMed>

                                                    <SubTittle></SubTittle>
                                                    <Tittle>{Intl.DateTimeFormat('pt-BR').format(new Date(consulta.datacon))}</Tittle>
                                                </TopConsult>
                                                <BodyConsult>
                                                    <Desc>{consulta.relatorioMedico}</Desc>
                                                </BodyConsult>
                                            </Consult>
                                        </BackConsult>
                        
                                    )
                                )
                            }
                        </Lista>
                    </Wrapper>
                <Footer />
            </Container>
        </>

    )

}