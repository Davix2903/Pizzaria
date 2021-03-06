﻿using PizzariaRioClaro.DAO;
using PizzariaRioClaro.Filters;
using PizzariaRioClaro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PizzariaRioClaro.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Logout()
        {
            Session["PessoaLogada"] = null;
            Session.Abandon();
            return RedirectToAction("Login", "Pessoa");
        }

        public ActionResult Autentica(string login, string senha)
        {
            PessoaDAO dao = new PessoaDAO();
            Pessoa pessoa = dao.Busca(login, senha);
            if (pessoa != null)
            {
                HttpContext.Session["PessoaLogada"] = pessoa;
                return RedirectToAction("Index", "Home");

            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        public ActionResult AdicionaPessoa(Pessoa pessoa, string novamenteASenha)
        {
            PessoaDAO dao = new PessoaDAO();
            pessoa.TipoDePessoa = 'C';
            if (pessoa.Senha == novamenteASenha)
            {
                dao.Adiciona(pessoa);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Funcionario = pessoa;
                return View("Cadastro");
            }
        }
    }
}