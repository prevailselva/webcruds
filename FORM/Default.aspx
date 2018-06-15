<%@ Page Title="" Language="C#" MasterPageFile="~/FORM/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="FORM_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="InHead" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="InBody" runat="Server">
    <form id="form1" runat="server">
        <section class="content">
        <div class="container-fluid">
            <!-- Small boxes (Stat box) -->
            <div class="row">
                <div class="col-lg-3 col-6">
                    <!-- small box -->
                    <div class="small-box bg-info">
                        <div class="inner">
                            <h3><asp:Label ID="lbl_stud_count" runat="server" Text=""></asp:Label></h3>

                            <p>Student Count</p>
                        </div>
                        <div class="icon">
                            <i class="ion ion-bag"></i>
                        </div>
                        <a href="#" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a>
                    </div>
                </div>
                <!-- ./col -->
                <div class="col-lg-3 col-6">
                    <!-- small box -->
                    <div class="small-box bg-success">
                        <div class="inner">
                            <h3><asp:Label ID="lbl_dme_count" runat="server" Text=""></asp:Label></h3>

                            <p>DME Overall Count</p>
                        </div>
                        <div class="icon">
                            <i class="ion ion-stats-bars"></i>
                        </div>
                        <a href="#" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a>
                    </div>
                </div>
                <!-- ./col -->
                <div class="col-lg-3 col-6">
                    <!-- small box -->
                    <div class="small-box bg-warning">
                        <div class="inner">
                            <h3><asp:Label ID="lbl_dce_count" runat="server" Text=""></asp:Label>
                                </h3>

                            <p>DCE Overall Count</p>
                        </div>
                        <div class="icon">
                            <i class="ion ion-person-add"></i>
                        </div>
                        <a href="#" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a>
                    </div>
                </div>
                <!-- ./col -->
                <div class="col-lg-3 col-6">
                    <!-- small box -->
                    <div class="small-box bg-danger">
                        <div class="inner">
                            <h3><asp:Label ID="lbl_dmt_count" runat="server" Text=""></asp:Label></h3>

                            <p>DMTE Overall Count</p>
                        </div>
                        <div class="icon">
                            <i class="ion ion-pie-graph"></i>
                        </div>
                        <a href="#" class="small-box-footer">More info <i class="fa fa-arrow-circle-right"></i></a>
                    </div>
                </div>
                <!-- ./col -->
            </div>
        </div>
    </section>
    </form>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="InFooter" runat="Server">
</asp:Content>

