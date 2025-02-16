import React, { useContext, useState } from 'react';
import { ErrorMessage, Field, Form, Formik } from 'formik';
import * as yup from 'yup';
import { ConstantAPIContext } from '../../context/ConstantAPIContext';
import AuthAPI, { SignInRequest } from '../../apis/AuthAPI';
import { toast } from 'react-toastify';
import { useNavigate } from 'react-router';
import StorageService from '../../services/StorageService';

const Login = () => {
  const user = StorageService.getUserInfo()
  const { setKullaniciVarMi } = useContext(ConstantAPIContext)
  const navigate = useNavigate()

  const loginValidationSchema = yup.object({
    email: yup.string()
      .required('Email zorunludur'),
    password: yup.string()
      .required('Şifre zorunludur')
  });



  return (
    <div className="bg-gradient-primary">
      <div className="container">
        <div className="row justify-content-center align-items-center d-flex vh-100">
          <div className="col-xl-10 col-lg-12 col-md-9">
            <div className="card o-hidden border-0 shadow-lg my-5">
              <div className="card-body p-0">
                <div className="row">
                  <div className="col-lg-6 d-none d-lg-block bg-login-image"></div>
                  <div className="col-lg-6">
                    <div className="p-5">
                      <div className="text-center">
                        <h1 className="h4 text-gray-900 mb-4">Welcome Back!</h1>
                      </div>
                      <Formik
                        initialValues={{ email: "", password: "" }}
                        validationSchema={loginValidationSchema}
                        onSubmit={(values, { setSubmitting }) => {
                          setSubmitting(true);
                          let request = new SignInRequest(values.email, values.password);
                          AuthAPI.signIn(request)
                            .then((response) => {
                              console.log(response)
                              if (response.sonuc === 0) {
                                setKullaniciVarMi(true)
                                toast.success("Giriş işlemi başarılı")
                              }
                              navigate(-1);
                            })
                            .catch((error) => {
                              toast.error("Kullanıcı adı veya şifreyi yanlış girdiniz.")
                            })
                            .finally(() => {
                              setSubmitting(false);
                            });
                        }}
                      >
                        <Form className="user">
                          <div className="form-group">
                            <Field
                              type="email"
                              name="email"
                              className="form-control form-control-user"
                              id="exampleInputEmail"
                              aria-describedby="emailHelp"
                              placeholder="Enter Email Address..."
                            />
                          </div>
                          <div className="form-group">
                            <Field
                              name="password"
                              type="password"
                              className="form-control form-control-user"
                              id="exampleInputPassword"
                              placeholder="Password"
                            />
                          </div>
                          <div className="form-group">
                            <div className="custom-control custom-checkbox small">
                              <input
                                type="checkbox"
                                className="custom-control-input"
                                id="customCheck"
                              />
                              <label className="custom-control-label" htmlFor="customCheck">
                                Remember Me
                              </label>
                            </div>
                          </div>
                          <button type='submit' className="btn btn-primary btn-user btn-block">
                            Login
                          </button>
                          <hr />
                          <ErrorMessage name="email" component="div" className="text-danger small mt-1" />
                        </Form>
                      </Formik>
                      <hr />
                      <div className="text-center">
                        <a className="small" href="forgot-password.html">
                          Forgot Password?
                        </a>
                      </div>
                      <div className="text-center">
                        <a className="small" href="register.html">
                          Create an Account!
                        </a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
};

export default Login;