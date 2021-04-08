@Code
    ViewData("Title") = "Home Page"
End Code

<!-- Bienvenida-->
<header class="masthead">
    <div class="container">
        <div class="masthead-subheading">Nueva serie comienza...</div>
        <div class="masthead-heading text-uppercase">En abril</div>
        <a class="btn btn-xl text-uppercase js-scroll-trigger" style="background-color: #3282b8; color:#fff"  href="#services">Conoce Websols</a>
    </div>
</header>
<!-- Quienes sommos-->
<section class="page-section" id="services" style="  background-color: #0f4c75;">
    <div class="container">
        <div class="text-center"> 
            <h2 class="section-heading text-uppercase" style="color:#bbe1fa;">Websols</h2>
            <h3 class="section-subheading" style="color:#fff;">Disfruta de todo el entretenimiento que te gusta en un solo lugar.</h3>
        </div>
        <div class="row text-center">
            <div class="col-md-4">
                <img src="~/Content/assets/img/who/videos6.png" />
                <h4 class="my-3" style="color:#bbe1fa;">Dos en uno</h4>
                <p style="color:#fff;">Tenemos todas tus películas favoritas para que disfrutes esa tarde de descanso que te mereces. O bien una tarde de tu música favorita</p>
            </div>
            <div class="col-md-4">
                <img src="~/Content/assets/img/who/planes9.png" />
                <h4 class="my-3" style="color:#bbe1fa;">Planes de suscripción</h4>
                <p style="color:#fff;">Te ofrecemos los mejores planes de suscripción y con la mejor paga para que puedas seguir disfrutando.</p>
            </div>
            <div class="col-md-4">
                <img src="~/Content/assets/img/who/secure.png" />
                <h4 class="my-3" style="color:#bbe1fa;">Seguridad garantizada</h4>
                <p style="color:#fff;">Tu seguridad nos importa, no revelaremos tu información personal. Con nosotros estas seguro.</p>
            </div>
        </div>
    </div>
</section>
<!-- Peliculas-->
<section class="page-section" id="portfolio" style="  background-color: #0f4c75;">
    <div class="container">
        <div class="text-center">
            <h2 class="section-heading text-uppercase" style="color:#bbe1fa;">Contenido Visual</h2>
            <h3 class="section-subheading" style="color:#fff;">Películas, series, vídeos musicales y más.</h3>
        </div>
        <div class="row">
            <div class="col-lg-4 col-sm-6 mb-4">
                <div class="portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal1">
                        <div class="portfolio-hover" style="background-color: #3282b8;">
                            <div class="portfolio-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                        </div>
                        <img class="img-fluid" src="@Url.Content("~/Content/assets/img/portfolio/spiderverse-sm.jpg")" alt="" />
                    </a>
                    <div class="portfolio-caption">
                        <div class="portfolio-caption-heading">Spiderman: Into the Spiderverse</div>
                        <div class="portfolio-caption-subheading text-muted">2018</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6 mb-4">
                <div class="portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal2">
                        <div class="portfolio-hover" style="background-color: #3282b8;">
                            <div class="portfolio-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                        </div>
                        <img class="img-fluid" src="@Url.Content("~/Content/assets/img/portfolio/friends-sm.jpg")" alt="" />
                    </a>
                    <div class="portfolio-caption">
                        <div class="portfolio-caption-heading">Friends</div>
                        <div class="portfolio-caption-subheading text-muted">1994</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6 mb-4">
                <div class="portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal3">
                        <div class="portfolio-hover" style="background-color: #3282b8;">
                            <div class="portfolio-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                        </div>
                        <img class="img-fluid" src="@Url.Content("~/Content/assets/img/portfolio/breakts-sm.jpg")" alt="" />
                    </a>
                    <div class="portfolio-caption">
                        <div class="portfolio-caption-heading">Break The Silence</div>
                        <div class="portfolio-caption-subheading text-muted">2020</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6 mb-4 mb-lg-0">
                <div class="portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal4">
                        <div class="portfolio-hover" style="background-color: #3282b8;">
                            <div class="portfolio-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                        </div>
                        <img class="img-fluid" src="@Url.Content("~/Content/assets/img/portfolio/modernfamily-sm.jpg")" alt="" />
                    </a>
                    <div class="portfolio-caption">
                        <div class="portfolio-caption-heading">Modern Family</div>
                        <div class="portfolio-caption-subheading text-muted">2008</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6 mb-4 mb-sm-0">
                <div class="portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal5">
                        <div class="portfolio-hover" style="background-color: #3282b8;">
                            <div class="portfolio-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                        </div>
                        <img class="img-fluid" src="@Url.Content("~/Content/assets/img/portfolio/500dias-sm.jpg")" alt="" />
                    </a>
                    <div class="portfolio-caption">
                        <div class="portfolio-caption-heading">500 Días con Summer</div>
                        <div class="portfolio-caption-subheading text-muted">2008</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6">
                <div class="portfolio-item">
                    <a class="portfolio-link" data-toggle="modal" href="#portfolioModal6">
                        <div class="portfolio-hover" style="background-color: #3282b8;">
                            <div class="portfolio-hover-content"><i class="fas fa-plus fa-3x"></i></div>
                        </div>
                        <img class="img-fluid" src="@Url.Content("~/Content/assets/img/portfolio/euforia-sm.jpg")" alt="" />
                    </a>
                    <div class="portfolio-caption">
                        <div class="portfolio-caption-heading">Euphoria</div>
                        <div class="portfolio-caption-subheading text-muted">2019</div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Música-->
<section class="page-section" id="about" style=" background-color: #0f4c75;">
    <div class="container">
        <div class="text-center">
            <h2 class="section-heading text-uppercase" style="color:#bbe1fa;">Música</h2>
            <h3 class="section-subheading" style="color:#fff;">Toda tu música y álbumes favoritos están aquí en Websols. ¡Escúchalos donde y cuando quieras!</h3>
        </div>
        <div class="row">
            <div class="col-lg-4 col-sm-6 mb-4">
                <div class="portfolio-item">
                    <img class="img-fluid" src="@Url.Content("~/Content/assets/img/albumes/wonder1.jpg")" alt="" />
                    <div class="portfolio-caption">
                        <br />
                        <div class="portfolio-caption-heading" style="color:#bbe1fa;">Wonder - Shawn Mendes</div>
                        <div class="portfolio-caption-subheading" style="color:#fff;">Fecha de lanzamiento: 4 de diciembre del 2020.</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6 mb-4">
                <div class="portfolio-item">
                    <img class="img-fluid" src="@Url.Content("~/Content/assets/img/albumes/future1.jpg")" alt="" />
                    <div class="portfolio-caption">
                        <br />
                        <div class="portfolio-caption-heading" style="color:#bbe1fa;">Future Nostalgia - Dua Lipa</div>
                        <div class="portfolio-caption-subheading" style="color:#fff;">Fecha de lanzamiento: 27 de marzo del 2020.</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6 mb-4">
                <div class="portfolio-item">
                    <img class="img-fluid" src="@Url.Content("~/Content/assets/img/albumes/after1.jpg")" alt="" />
                    <div class="portfolio-caption">
                        <br />
                        <div class="portfolio-caption-heading" style="color:#bbe1fa;">After Hours - The Weekndl</div>
                        <div class="portfolio-caption-subheading" style="color:#fff;">Fecha de lanzamiento: 20 de marzo del 2020.</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6 mb-4 mb-lg-0">
                <div class="portfolio-item">
                    <img class="img-fluid" src="@Url.Content("~/Content/assets/img/albumes/bts1.jpg")" alt="" />
                    <div class="portfolio-caption">
                        <br />
                        <div class="portfolio-caption-heading" style="color:#bbe1fa;">Dynamite - BTS</div>
                        <div class="portfolio-caption-subheading" style="color:#fff;">Fecha de lanzamiento: 21 de agosto del 2020.</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6 mb-4 mb-sm-0">
                <div class="portfolio-item">
                    <img class="img-fluid" src="@Url.Content("~/Content/assets/img/albumes/karolg1.jpg")" alt="" />
                    <div class="portfolio-caption">
                        <br />
                        <div class="portfolio-caption-heading" style="color:#bbe1fa;">Bichota - Karol G</div>
                        <div class="portfolio-caption-subheading" style="color:#fff;">Fecha de lanzamiento: 22 de octubre 2020.</div>
                    </div>
                </div>
            </div>
            <div class="col-lg-4 col-sm-6">
                <div class="portfolio-item">
                    <img class="img-fluid" src="@Url.Content("~/Content/assets/img/albumes/selena1.jpg")" alt="" />
                    <div class="portfolio-caption">
                        <br />
                        <div class="portfolio-caption-heading" style="color:#bbe1fa;">Baila Conmigo - Selena Gomez feat. Rauw  </div>
                        <div class="portfolio-caption-subheading" style="color:#fff;">Fecha de lanzamiento: 29 de enero 2021. </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Catálogo-->
<section class="page-section" id="team" align="center" style=" background-color: #0f4c75;">
    <div class="container">
        <div class="text-center">
            <h2 class="section-heading text-uppercase" style="color:#bbe1fa;">Nuestros Catálogos</h2>
            <h3 class="section-subheading" style="color:#fff;">Nuestros catálogos completos</h3>
        </div>
        <div class="row" align="center">
            <div class="col-lg-4">
                <div class="team-member">
                    <img class="mx-auto rounded-circle" src="@Url.Content("~/Content/assets/img/team/1.png")" alt="" />
                    <h4>Catálogo Música</h4>
                </div>
            </div>
            <div class="col-lg-4">
                <div class="team-member">
                    <img class="mx-auto rounded-circle" src="@Url.Content("~/Content/assets/img/team/2.png")" alt="" />
                    <h4>Catálogo Vídeos</h4>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-8 mx-auto text-center"><p class="large text-muted">¡Contamos con mas de mil opciones para ver y escuchar!</p></div>
        </div>
    </div>
</section>

<!-- Contact-->
<section class="page-section" id="contact" style=" background-color: #0f4c75;">
    <div class="container">
        <div class="text-center">
            <h2 class="section-heading text-uppercase" style="color:#bbe1fa;">Disponible en tus dispositivos favoritos</h2>
        </div>
        <div class="row text-center">
            <div class="col-md-4">
                <img src="@Url.Content("~/Content/assets/img/dispositivos/smart1.png")" alt="" />
                <h4 class="my-3" style="color:#bbe1fa;">Smart TV</h4>
                <p style="color:#fff">Samsung</p>
                <p style="color:#fff">LG</p>
                <p style="color:#fff">Sony</p>
                <p style="color:#fff">Apple TV</p>
                <p style="color:#fff">Google Chromecast</p>
            </div>
            <div class="col-md-4">
                <img src="@Url.Content("~/Content/assets/img/dispositivos/laptop6.png")" alt="" />
                <h4 class="my-3" style="color:#bbe1fa;">Computadoras</h4>
                <p style="color:#fff">Windows PC</p>
                <p style="color:#fff">Mac OS</p>
                <p style="color:#fff">Chrome OS</p>
            </div>
            <div class="col-md-4">
                <img src="@Url.Content("~/Content/assets/img/dispositivos/phone7.png")" />
                <h4 class="my-3" style="color:#bbe1fa;">Smartphone</h4>
                <p style="color:#fff">Iphone y Ipads</p>
                <p style="color:#fff">Celulares y Tablets Android</p>
                <p style="color:#fff">Tablets Amazon Fire</p>
            </div>
        </div>
    </div>
</section>