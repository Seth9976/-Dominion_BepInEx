using System;

namespace UnityEngine.VFX
{
	// Token: 0x0200000F RID: 15
	public enum VFXExpressionOperation
	{
		// Token: 0x040000BA RID: 186
		None,
		// Token: 0x040000BB RID: 187
		Value,
		// Token: 0x040000BC RID: 188
		Combine2f,
		// Token: 0x040000BD RID: 189
		Combine3f,
		// Token: 0x040000BE RID: 190
		Combine4f,
		// Token: 0x040000BF RID: 191
		ExtractComponent,
		// Token: 0x040000C0 RID: 192
		DeltaTime,
		// Token: 0x040000C1 RID: 193
		TotalTime,
		// Token: 0x040000C2 RID: 194
		SystemSeed,
		// Token: 0x040000C3 RID: 195
		LocalToWorld,
		// Token: 0x040000C4 RID: 196
		WorldToLocal,
		// Token: 0x040000C5 RID: 197
		FrameIndex,
		// Token: 0x040000C6 RID: 198
		PlayRate,
		// Token: 0x040000C7 RID: 199
		UnscaledDeltaTime,
		// Token: 0x040000C8 RID: 200
		ManagerMaxDeltaTime,
		// Token: 0x040000C9 RID: 201
		ManagerFixedTimeStep,
		// Token: 0x040000CA RID: 202
		GameDeltaTime,
		// Token: 0x040000CB RID: 203
		GameUnscaledDeltaTime,
		// Token: 0x040000CC RID: 204
		GameSmoothDeltaTime,
		// Token: 0x040000CD RID: 205
		GameTotalTime,
		// Token: 0x040000CE RID: 206
		GameUnscaledTotalTime,
		// Token: 0x040000CF RID: 207
		GameTotalTimeSinceSceneLoad,
		// Token: 0x040000D0 RID: 208
		GameTimeScale,
		// Token: 0x040000D1 RID: 209
		Sin,
		// Token: 0x040000D2 RID: 210
		Cos,
		// Token: 0x040000D3 RID: 211
		Tan,
		// Token: 0x040000D4 RID: 212
		ASin,
		// Token: 0x040000D5 RID: 213
		ACos,
		// Token: 0x040000D6 RID: 214
		ATan,
		// Token: 0x040000D7 RID: 215
		Abs,
		// Token: 0x040000D8 RID: 216
		Sign,
		// Token: 0x040000D9 RID: 217
		Saturate,
		// Token: 0x040000DA RID: 218
		Ceil,
		// Token: 0x040000DB RID: 219
		Round,
		// Token: 0x040000DC RID: 220
		Frac,
		// Token: 0x040000DD RID: 221
		Floor,
		// Token: 0x040000DE RID: 222
		Log2,
		// Token: 0x040000DF RID: 223
		Mul,
		// Token: 0x040000E0 RID: 224
		Divide,
		// Token: 0x040000E1 RID: 225
		Add,
		// Token: 0x040000E2 RID: 226
		Subtract,
		// Token: 0x040000E3 RID: 227
		Min,
		// Token: 0x040000E4 RID: 228
		Max,
		// Token: 0x040000E5 RID: 229
		Pow,
		// Token: 0x040000E6 RID: 230
		ATan2,
		// Token: 0x040000E7 RID: 231
		TRSToMatrix,
		// Token: 0x040000E8 RID: 232
		InverseMatrix,
		// Token: 0x040000E9 RID: 233
		InverseTRSMatrix,
		// Token: 0x040000EA RID: 234
		TransposeMatrix,
		// Token: 0x040000EB RID: 235
		ExtractPositionFromMatrix,
		// Token: 0x040000EC RID: 236
		ExtractAnglesFromMatrix,
		// Token: 0x040000ED RID: 237
		ExtractScaleFromMatrix,
		// Token: 0x040000EE RID: 238
		TransformMatrix,
		// Token: 0x040000EF RID: 239
		TransformPos,
		// Token: 0x040000F0 RID: 240
		TransformVec,
		// Token: 0x040000F1 RID: 241
		TransformDir,
		// Token: 0x040000F2 RID: 242
		TransformVector4,
		// Token: 0x040000F3 RID: 243
		Vector3sToMatrix,
		// Token: 0x040000F4 RID: 244
		Vector4sToMatrix,
		// Token: 0x040000F5 RID: 245
		MatrixToVector3s,
		// Token: 0x040000F6 RID: 246
		MatrixToVector4s,
		// Token: 0x040000F7 RID: 247
		SampleCurve,
		// Token: 0x040000F8 RID: 248
		SampleGradient,
		// Token: 0x040000F9 RID: 249
		SampleMeshFloat,
		// Token: 0x040000FA RID: 250
		SampleMeshFloat2,
		// Token: 0x040000FB RID: 251
		SampleMeshFloat3,
		// Token: 0x040000FC RID: 252
		SampleMeshFloat4,
		// Token: 0x040000FD RID: 253
		SampleMeshColor,
		// Token: 0x040000FE RID: 254
		SampleMeshVertexFloat,
		// Token: 0x040000FF RID: 255
		SampleMeshVertexFloat2,
		// Token: 0x04000100 RID: 256
		SampleMeshVertexFloat3,
		// Token: 0x04000101 RID: 257
		SampleMeshVertexFloat4,
		// Token: 0x04000102 RID: 258
		SampleMeshVertexColor,
		// Token: 0x04000103 RID: 259
		SampleMeshIndex,
		// Token: 0x04000104 RID: 260
		VertexBufferFromMesh,
		// Token: 0x04000105 RID: 261
		VertexBufferFromSkinnedMeshRenderer,
		// Token: 0x04000106 RID: 262
		IndexBufferFromMesh,
		// Token: 0x04000107 RID: 263
		MeshFromSkinnedMeshRenderer,
		// Token: 0x04000108 RID: 264
		BakeCurve,
		// Token: 0x04000109 RID: 265
		BakeGradient,
		// Token: 0x0400010A RID: 266
		BitwiseLeftShift,
		// Token: 0x0400010B RID: 267
		BitwiseRightShift,
		// Token: 0x0400010C RID: 268
		BitwiseOr,
		// Token: 0x0400010D RID: 269
		BitwiseAnd,
		// Token: 0x0400010E RID: 270
		BitwiseXor,
		// Token: 0x0400010F RID: 271
		BitwiseComplement,
		// Token: 0x04000110 RID: 272
		CastUintToFloat,
		// Token: 0x04000111 RID: 273
		CastIntToFloat,
		// Token: 0x04000112 RID: 274
		CastFloatToUint,
		// Token: 0x04000113 RID: 275
		CastIntToUint,
		// Token: 0x04000114 RID: 276
		CastFloatToInt,
		// Token: 0x04000115 RID: 277
		CastUintToInt,
		// Token: 0x04000116 RID: 278
		RGBtoHSV,
		// Token: 0x04000117 RID: 279
		HSVtoRGB,
		// Token: 0x04000118 RID: 280
		Condition,
		// Token: 0x04000119 RID: 281
		Branch,
		// Token: 0x0400011A RID: 282
		GenerateRandom,
		// Token: 0x0400011B RID: 283
		GenerateFixedRandom,
		// Token: 0x0400011C RID: 284
		ExtractMatrixFromMainCamera,
		// Token: 0x0400011D RID: 285
		ExtractFOVFromMainCamera,
		// Token: 0x0400011E RID: 286
		ExtractNearPlaneFromMainCamera,
		// Token: 0x0400011F RID: 287
		ExtractFarPlaneFromMainCamera,
		// Token: 0x04000120 RID: 288
		ExtractAspectRatioFromMainCamera,
		// Token: 0x04000121 RID: 289
		ExtractPixelDimensionsFromMainCamera,
		// Token: 0x04000122 RID: 290
		GetBufferFromMainCamera,
		// Token: 0x04000123 RID: 291
		LogicalAnd,
		// Token: 0x04000124 RID: 292
		LogicalOr,
		// Token: 0x04000125 RID: 293
		LogicalNot,
		// Token: 0x04000126 RID: 294
		ValueNoise1D,
		// Token: 0x04000127 RID: 295
		ValueNoise2D,
		// Token: 0x04000128 RID: 296
		ValueNoise3D,
		// Token: 0x04000129 RID: 297
		ValueCurlNoise2D,
		// Token: 0x0400012A RID: 298
		ValueCurlNoise3D,
		// Token: 0x0400012B RID: 299
		PerlinNoise1D,
		// Token: 0x0400012C RID: 300
		PerlinNoise2D,
		// Token: 0x0400012D RID: 301
		PerlinNoise3D,
		// Token: 0x0400012E RID: 302
		PerlinCurlNoise2D,
		// Token: 0x0400012F RID: 303
		PerlinCurlNoise3D,
		// Token: 0x04000130 RID: 304
		CellularNoise1D,
		// Token: 0x04000131 RID: 305
		CellularNoise2D,
		// Token: 0x04000132 RID: 306
		CellularNoise3D,
		// Token: 0x04000133 RID: 307
		CellularCurlNoise2D,
		// Token: 0x04000134 RID: 308
		CellularCurlNoise3D,
		// Token: 0x04000135 RID: 309
		VoroNoise2D,
		// Token: 0x04000136 RID: 310
		MeshVertexCount,
		// Token: 0x04000137 RID: 311
		MeshChannelOffset,
		// Token: 0x04000138 RID: 312
		MeshChannelInfos,
		// Token: 0x04000139 RID: 313
		MeshVertexStride,
		// Token: 0x0400013A RID: 314
		MeshIndexCount,
		// Token: 0x0400013B RID: 315
		MeshIndexFormat,
		// Token: 0x0400013C RID: 316
		BufferCount,
		// Token: 0x0400013D RID: 317
		TextureWidth,
		// Token: 0x0400013E RID: 318
		TextureHeight,
		// Token: 0x0400013F RID: 319
		TextureDepth,
		// Token: 0x04000140 RID: 320
		ReadEventAttribute,
		// Token: 0x04000141 RID: 321
		SpawnerStateNewLoop,
		// Token: 0x04000142 RID: 322
		SpawnerStateLoopState,
		// Token: 0x04000143 RID: 323
		SpawnerStateSpawnCount,
		// Token: 0x04000144 RID: 324
		SpawnerStateDeltaTime,
		// Token: 0x04000145 RID: 325
		SpawnerStateTotalTime,
		// Token: 0x04000146 RID: 326
		SpawnerStateDelayBeforeLoop,
		// Token: 0x04000147 RID: 327
		SpawnerStateLoopDuration,
		// Token: 0x04000148 RID: 328
		SpawnerStateDelayAfterLoop,
		// Token: 0x04000149 RID: 329
		SpawnerStateLoopIndex,
		// Token: 0x0400014A RID: 330
		SpawnerStateLoopCount
	}
}
