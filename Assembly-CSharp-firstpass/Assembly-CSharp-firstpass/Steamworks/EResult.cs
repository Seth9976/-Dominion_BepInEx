using System;

namespace Steamworks
{
	// Token: 0x02000280 RID: 640
	public enum EResult
	{
		// Token: 0x040023DD RID: 9181
		k_EResultNone,
		// Token: 0x040023DE RID: 9182
		k_EResultOK,
		// Token: 0x040023DF RID: 9183
		k_EResultFail,
		// Token: 0x040023E0 RID: 9184
		k_EResultNoConnection,
		// Token: 0x040023E1 RID: 9185
		k_EResultInvalidPassword = 5,
		// Token: 0x040023E2 RID: 9186
		k_EResultLoggedInElsewhere,
		// Token: 0x040023E3 RID: 9187
		k_EResultInvalidProtocolVer,
		// Token: 0x040023E4 RID: 9188
		k_EResultInvalidParam,
		// Token: 0x040023E5 RID: 9189
		k_EResultFileNotFound,
		// Token: 0x040023E6 RID: 9190
		k_EResultBusy,
		// Token: 0x040023E7 RID: 9191
		k_EResultInvalidState,
		// Token: 0x040023E8 RID: 9192
		k_EResultInvalidName,
		// Token: 0x040023E9 RID: 9193
		k_EResultInvalidEmail,
		// Token: 0x040023EA RID: 9194
		k_EResultDuplicateName,
		// Token: 0x040023EB RID: 9195
		k_EResultAccessDenied,
		// Token: 0x040023EC RID: 9196
		k_EResultTimeout,
		// Token: 0x040023ED RID: 9197
		k_EResultBanned,
		// Token: 0x040023EE RID: 9198
		k_EResultAccountNotFound,
		// Token: 0x040023EF RID: 9199
		k_EResultInvalidSteamID,
		// Token: 0x040023F0 RID: 9200
		k_EResultServiceUnavailable,
		// Token: 0x040023F1 RID: 9201
		k_EResultNotLoggedOn,
		// Token: 0x040023F2 RID: 9202
		k_EResultPending,
		// Token: 0x040023F3 RID: 9203
		k_EResultEncryptionFailure,
		// Token: 0x040023F4 RID: 9204
		k_EResultInsufficientPrivilege,
		// Token: 0x040023F5 RID: 9205
		k_EResultLimitExceeded,
		// Token: 0x040023F6 RID: 9206
		k_EResultRevoked,
		// Token: 0x040023F7 RID: 9207
		k_EResultExpired,
		// Token: 0x040023F8 RID: 9208
		k_EResultAlreadyRedeemed,
		// Token: 0x040023F9 RID: 9209
		k_EResultDuplicateRequest,
		// Token: 0x040023FA RID: 9210
		k_EResultAlreadyOwned,
		// Token: 0x040023FB RID: 9211
		k_EResultIPNotFound,
		// Token: 0x040023FC RID: 9212
		k_EResultPersistFailed,
		// Token: 0x040023FD RID: 9213
		k_EResultLockingFailed,
		// Token: 0x040023FE RID: 9214
		k_EResultLogonSessionReplaced,
		// Token: 0x040023FF RID: 9215
		k_EResultConnectFailed,
		// Token: 0x04002400 RID: 9216
		k_EResultHandshakeFailed,
		// Token: 0x04002401 RID: 9217
		k_EResultIOFailure,
		// Token: 0x04002402 RID: 9218
		k_EResultRemoteDisconnect,
		// Token: 0x04002403 RID: 9219
		k_EResultShoppingCartNotFound,
		// Token: 0x04002404 RID: 9220
		k_EResultBlocked,
		// Token: 0x04002405 RID: 9221
		k_EResultIgnored,
		// Token: 0x04002406 RID: 9222
		k_EResultNoMatch,
		// Token: 0x04002407 RID: 9223
		k_EResultAccountDisabled,
		// Token: 0x04002408 RID: 9224
		k_EResultServiceReadOnly,
		// Token: 0x04002409 RID: 9225
		k_EResultAccountNotFeatured,
		// Token: 0x0400240A RID: 9226
		k_EResultAdministratorOK,
		// Token: 0x0400240B RID: 9227
		k_EResultContentVersion,
		// Token: 0x0400240C RID: 9228
		k_EResultTryAnotherCM,
		// Token: 0x0400240D RID: 9229
		k_EResultPasswordRequiredToKickSession,
		// Token: 0x0400240E RID: 9230
		k_EResultAlreadyLoggedInElsewhere,
		// Token: 0x0400240F RID: 9231
		k_EResultSuspended,
		// Token: 0x04002410 RID: 9232
		k_EResultCancelled,
		// Token: 0x04002411 RID: 9233
		k_EResultDataCorruption,
		// Token: 0x04002412 RID: 9234
		k_EResultDiskFull,
		// Token: 0x04002413 RID: 9235
		k_EResultRemoteCallFailed,
		// Token: 0x04002414 RID: 9236
		k_EResultPasswordUnset,
		// Token: 0x04002415 RID: 9237
		k_EResultExternalAccountUnlinked,
		// Token: 0x04002416 RID: 9238
		k_EResultPSNTicketInvalid,
		// Token: 0x04002417 RID: 9239
		k_EResultExternalAccountAlreadyLinked,
		// Token: 0x04002418 RID: 9240
		k_EResultRemoteFileConflict,
		// Token: 0x04002419 RID: 9241
		k_EResultIllegalPassword,
		// Token: 0x0400241A RID: 9242
		k_EResultSameAsPreviousValue,
		// Token: 0x0400241B RID: 9243
		k_EResultAccountLogonDenied,
		// Token: 0x0400241C RID: 9244
		k_EResultCannotUseOldPassword,
		// Token: 0x0400241D RID: 9245
		k_EResultInvalidLoginAuthCode,
		// Token: 0x0400241E RID: 9246
		k_EResultAccountLogonDeniedNoMail,
		// Token: 0x0400241F RID: 9247
		k_EResultHardwareNotCapableOfIPT,
		// Token: 0x04002420 RID: 9248
		k_EResultIPTInitError,
		// Token: 0x04002421 RID: 9249
		k_EResultParentalControlRestricted,
		// Token: 0x04002422 RID: 9250
		k_EResultFacebookQueryError,
		// Token: 0x04002423 RID: 9251
		k_EResultExpiredLoginAuthCode,
		// Token: 0x04002424 RID: 9252
		k_EResultIPLoginRestrictionFailed,
		// Token: 0x04002425 RID: 9253
		k_EResultAccountLockedDown,
		// Token: 0x04002426 RID: 9254
		k_EResultAccountLogonDeniedVerifiedEmailRequired,
		// Token: 0x04002427 RID: 9255
		k_EResultNoMatchingURL,
		// Token: 0x04002428 RID: 9256
		k_EResultBadResponse,
		// Token: 0x04002429 RID: 9257
		k_EResultRequirePasswordReEntry,
		// Token: 0x0400242A RID: 9258
		k_EResultValueOutOfRange,
		// Token: 0x0400242B RID: 9259
		k_EResultUnexpectedError,
		// Token: 0x0400242C RID: 9260
		k_EResultDisabled,
		// Token: 0x0400242D RID: 9261
		k_EResultInvalidCEGSubmission,
		// Token: 0x0400242E RID: 9262
		k_EResultRestrictedDevice,
		// Token: 0x0400242F RID: 9263
		k_EResultRegionLocked,
		// Token: 0x04002430 RID: 9264
		k_EResultRateLimitExceeded,
		// Token: 0x04002431 RID: 9265
		k_EResultAccountLoginDeniedNeedTwoFactor,
		// Token: 0x04002432 RID: 9266
		k_EResultItemDeleted,
		// Token: 0x04002433 RID: 9267
		k_EResultAccountLoginDeniedThrottle,
		// Token: 0x04002434 RID: 9268
		k_EResultTwoFactorCodeMismatch,
		// Token: 0x04002435 RID: 9269
		k_EResultTwoFactorActivationCodeMismatch,
		// Token: 0x04002436 RID: 9270
		k_EResultAccountAssociatedToMultiplePartners,
		// Token: 0x04002437 RID: 9271
		k_EResultNotModified,
		// Token: 0x04002438 RID: 9272
		k_EResultNoMobileDevice,
		// Token: 0x04002439 RID: 9273
		k_EResultTimeNotSynced,
		// Token: 0x0400243A RID: 9274
		k_EResultSmsCodeFailed,
		// Token: 0x0400243B RID: 9275
		k_EResultAccountLimitExceeded,
		// Token: 0x0400243C RID: 9276
		k_EResultAccountActivityLimitExceeded,
		// Token: 0x0400243D RID: 9277
		k_EResultPhoneActivityLimitExceeded,
		// Token: 0x0400243E RID: 9278
		k_EResultRefundToWallet,
		// Token: 0x0400243F RID: 9279
		k_EResultEmailSendFailure,
		// Token: 0x04002440 RID: 9280
		k_EResultNotSettled,
		// Token: 0x04002441 RID: 9281
		k_EResultNeedCaptcha,
		// Token: 0x04002442 RID: 9282
		k_EResultGSLTDenied,
		// Token: 0x04002443 RID: 9283
		k_EResultGSOwnerDenied,
		// Token: 0x04002444 RID: 9284
		k_EResultInvalidItemType,
		// Token: 0x04002445 RID: 9285
		k_EResultIPBanned,
		// Token: 0x04002446 RID: 9286
		k_EResultGSLTExpired,
		// Token: 0x04002447 RID: 9287
		k_EResultInsufficientFunds,
		// Token: 0x04002448 RID: 9288
		k_EResultTooManyPending,
		// Token: 0x04002449 RID: 9289
		k_EResultNoSiteLicensesFound,
		// Token: 0x0400244A RID: 9290
		k_EResultWGNetworkSendExceeded,
		// Token: 0x0400244B RID: 9291
		k_EResultAccountNotFriends,
		// Token: 0x0400244C RID: 9292
		k_EResultLimitedUserAccount,
		// Token: 0x0400244D RID: 9293
		k_EResultCantRemoveItem,
		// Token: 0x0400244E RID: 9294
		k_EResultAccountDeleted,
		// Token: 0x0400244F RID: 9295
		k_EResultExistingUserCancelledLicense,
		// Token: 0x04002450 RID: 9296
		k_EResultCommunityCooldown
	}
}
