import React from 'react'
import { useForm } from 'react-hook-form';

import Footer from '../../Components/Footer'
import Header from '../../Components/Header'
import api from '../../services/api';
import tokenDecode from '../../services/auth';
import { Wrapper } from '../Consultas/styles'
import {Container, Window, Tittle, ContentForm, Form, TittleInput, Input, Select, Date, FooterButtons, Cancel, Schedule} from './styles'

export default function NovaConsulta() {

    const {register, handleSubmit} = useForm();

    const emailuser = tokenDecode().Email

    function Agendar(data) {

        const iduser = tokenDecode().jti

        console.log(data.clinica + ' ' + data.medico + ' ' + iduser + ' ' + data.data);

        api.post('/consultum',{
            idUsuario: iduser,
            idSituacao: 1,
            idMedico: data.medico,
            idClinica: data.clinica,
            datacon: data.data

        })
    }

    return(
        <>
        <Container>
            <Header/>
            <Wrapper>
                <Window>
                    <Tittle>Nova Consulta</Tittle>
                    <ContentForm>

                        <Form onSubmit={handleSubmit(Agendar)}>
                            <TittleInput>Nome do Paciente</TittleInput>
                            <Input value={emailuser} />
                            <TittleInput>Médico</TittleInput>
                            <Select {...register('medico')}>
                                <option value='1'>Helena</option>
                                <option value='2'>Lemos</option>
                                <option value='3'>Possarle</option>
                            </Select>
                            <TittleInput>Clínica</TittleInput>
                            <Select {...register('clinica')}>
                                <option value='1'>Penha</option>
                                <option value='2'>Carrão</option>
                                <option value='3'>Tatuapé</option>
                            </Select>
                            <TittleInput>Data do Agendamento</TittleInput>
                            <Date type='datetime-local' {...register('data')} />
                            <FooterButtons>
                                <Cancel>Cancel</Cancel>
                                <Schedule type='submit' value='Agendar'/>
                            </FooterButtons>
                        </Form>
                    </ContentForm>
                </Window>
            </Wrapper>
            <Footer/>
        </Container>
        </>
    )

}