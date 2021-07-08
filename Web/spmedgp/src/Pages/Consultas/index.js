import React, {useEffect, useState} from 'react'
import api from '../../services/api'
import { useForm } from 'react-hook-form';
import { useHistory } from 'react-router-dom';

import Header from '../../Components/Header'
import Footer from '../../Components/Footer'

import { Container, Wrapper, Lista, BackConsult, Consult, TopConsult, InfoMed, Tittle, NomeMed, SubTittle, BodyConsult, Desc, InputDesc, InputDescNone  } from './styles'



export default function Consultas(){

    const [listaCons, setListaCons ] = useState([]);
    const {register, handleSubmit } = useForm();
    const history = useHistory();

    async function BuscarCons() {

        const token = await localStorage.getItem('token-userup')
        
        console.log(token);
        const resposta = await api('/consultum/minhas', {

            headers : {
                'Authorization' : 'Bearer ' + token
            }

        })

        console.log(resposta);

        const data = resposta.data
        
        // console.log(data);
        
        setListaCons(data)

    }

    async function newDesc(data) {
        
        const response = await api.put('/consultum/' + data.idConsulta, {
            relatorioMedico : data.descricao

        })

        console.log(response.status);

        if (response.status === 200) {
            
            BuscarCons();
        }

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
                                    <li key={consulta.idConsulta}>
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
                                                    
                                                    {
                                                        consulta.idUsuarioNavigation.idTipoUsuario === 2 &&
                                                        // <form onSubmit={ handleSubmit(attConsulta()) }>
                                                        <form onSubmit={handleSubmit(newDesc)}>
                                                            
                                                            <Desc> {consulta.relatorioMedico} </Desc>
                                                            <InputDesc {...register('descricao')} type='text' />
                                                            <InputDescNone {...register('idConsulta')} type='text' value={consulta.idConsulta} />
                                                            <input type='submit' value='Submit'/>
                                                        </form>
                                                    }
                                                    
                                                    {

                                                        consulta.idUsuarioNavigation.idTipoUsuario === 1 &&                                                        

                                                        <Desc> {consulta.relatorioMedico} </Desc>

                                                    }
                                                    


                                                        
                                                </BodyConsult>
                                            </Consult>
                                        </BackConsult>
                                    </li>
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