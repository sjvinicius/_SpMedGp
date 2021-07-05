import React, { useState } from 'react'

import { Container, Wrapper, Logo, Tittle, Form, InputLog, ButtonLog } from './styles'

import logo from '../../assets/img/img/Logo_P1.png'
// import api from '../../services/api';

export default function Login() {
    
    const [email, setEmail] = useState('');
    const [pwd, setPwd] = useState('');

    // function Autenticar(event) {
    //     event.preventDefault()
    // }

    return (
        <>
            <Container>
                <Wrapper>
                    <Logo src={logo} />
                    <Tittle>Login</Tittle>
                    <Form >
                        <InputLog placeholder='Email' type='Email' value={ email } onChange={ () => setEmail() } />
                        <InputLog placeholder='Password' type='Password' value={ pwd } onChange={ () => setPwd() } />
                        <ButtonLog  
                            type='submit'
                        > 
                        Acessar 
                        </ButtonLog>
                    </Form>
                </Wrapper>
            </Container>
        </>

    )

}