import { RouteConfig } from "../common/common.route.config"
import express, { Application, Request, Response } from "express"
import MoneyController from "./money.controller"
import { body, check } from "express-validator"
import AuthMiddleware from "../authentication/authentication.middleware"


export class MoneyRoutes extends RouteConfig {
  constructor(app: Application) {
    super(app, "MoneyRoutes")
  }
  configureRoutes() {
    this.app.route(`/money`).get([AuthMiddleware.authenticateAccessToken, AuthMiddleware.checkRoles(["Admin"]), MoneyController.getMoneyByHashtagTwitter])

    this.app.get(`/money/:id`, [
      check('id').isInt().withMessage("The 'id' parameter must be an integer"), ],
      [AuthMiddleware.authenticateAccessToken, AuthMiddleware.checkRoles(["Admin"]), MoneyController.getMoneyBySocialActivistId])

    this.app.get(`/moneybyids/:sa_id/:campaign_id`, [
      check('sa_id').isInt().withMessage("The 'sa_id' parameter must be an integer"),
      check('campaign_id').isInt().withMessage("The 'campaign_id' parameter must be an integer"),],
      [MoneyController.getMoneyBySocialActivistIdAndCampaignId])
    //this.app.route(`/money`).post([MoneyController.addMoneyByHashtagTwitter])
    this.app.post(`/money`, [
      body('social_activist_id').isInt().withMessage("The 'social_activist_id' parameter must be an integer"),
      body('campaign_id').isInt().withMessage("The 'campaign_id' parameter must be an integer"),
      body('money').isInt().withMessage("The 'money' parameter must be an integer"),
    ],[/*AuthMiddleware.authenticateAccessToken, AuthMiddleware.checkRoles(["Admin"]),*/ MoneyController.addMoneyByHashtagTwitter])

    //this.app.route(`/money`).put([MoneyController.updateMoneyByHashtagTwitter])
    this.app.put(`/money`, [
      body('social_activist_id').isInt().withMessage("The 'social_activist_id' parameter must be an integer"),
      body('campaign_id').isInt().withMessage("The 'campaign_id' parameter must be an integer"),
    ], [MoneyController.updateMoneyByHashtagTwitter])

    return this.app
  }
}