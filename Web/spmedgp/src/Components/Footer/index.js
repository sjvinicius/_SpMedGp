import React from 'react'

import logo from '../../assets/img/img/Logo_R21.png'

import { Container, ContentHeader, ContentItem, TextHeader, Logo } from './styles'

export default function Footer() {
    
    return (
        <>
            <Container>
                <ContentHeader>
                    <ContentItem>
                        <TextHeader> SÃO PAULO MEDICAL GROUP </TextHeader>
                        <TextHeader> Todos os direitos reservados a ® Vinicius Silva </TextHeader>
                        <TextHeader> Contatos: sjf.vinicius@gmail.com </TextHeader>
                        <TextHeader> Telefone: (11) 9-5980-5820 </TextHeader>
                    </ContentItem>
                    <Logo src={logo}/>
                </ContentHeader>
            </Container>    
        </>

    )

}