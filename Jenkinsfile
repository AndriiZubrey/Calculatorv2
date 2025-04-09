pipeline {
    agent any

    environment {
        DOTNET_HOME = 'C:\\Program Files\\dotnet'
        PATH = "${env.DOTNET_HOME};${env.PATH}"
    }

    stages {
        stage('Checkout') {
            steps {
                checkout scm
            }
        }
        stage('Restore') {
            steps {
                bat '"${env.DOTNET_HOME}\\dotnet" restore'
            }
        }
        stage('Build') {
            steps {
                bat '"${env.DOTNET_HOME}\\dotnet" build --configuration Release'
            }
        }
        stage('Test') {
            steps {
                bat '"${env.DOTNET_HOME}\\dotnet" test --configuration Release'
            }
        }
        stage('Cake Build') {
            steps {
                bat '"${env.DOTNET_HOME}\\dotnet" cake build.cake --target=Run'
            }
        }
    }
    post {
        always {
            cleanWs()
        }
    }
}
