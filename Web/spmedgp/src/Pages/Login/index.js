import React from 'react'
import { useForm } from 'react-hook-form';
import { useHistory } from 'react-router-dom';

import { Container, Wrapper, Logo, Tittle, Form, InputLog, ErroMsg, ButtonLog } from './styles'

import logo from '../../assets/img/img/Logo_P1.png'

import api from '../../services/api';
import tokenDecode from '../../services/auth'

export default function Login() {
    
    const {register, handleSubmit } = useForm();
    const history = useHistory();
    var erromsg = '';

    async function Autenticar(data) {
        
        console.log(data)

        if (data.email === "" || data.pwd === "") {
            
            
            erromsg = 'Preencha Todos os Campos Antes de Prosseguir !';

        }

        const response = await api.post('/login',{
            email: data.email,
            senha: data.pwd

        })

        console.log(response.data.token);

        localStorage.setItem('token-userup', response.data.token)
        
        // history.location.pathname('/consultas')

        console.log(tokenDecode());
        
        // history.push('../../consultas')
        
        if (tokenDecode().role === '1') {
            
            history.push('/consultas')
            
        }
        
        history.push('/consultas');

    }
    
    return (
        <>
            <Container>
                <Wrapper>
                    <Logo src={logo} />
                    <Tittle>Login</Tittle>
                    <Form onSubmit= {handleSubmit( Autenticar )}>
                        <InputLog {...register('email')} placeholder='Email' type='email'/>
                        <InputLog {...register('pwd')} placeholder='Password' type='password' />
                        <ErroMsg>{erromsg}</ErroMsg>
                        <ButtonLog type='submit' value='submit' />
                    </Form>
                </Wrapper>
            </Container>
        </>

    )

}