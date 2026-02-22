using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x020002D8 RID: 728
	public sealed class RayTracingShader : Object
	{
		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002317 RID: 8983 RVA: 0x00014A35 File Offset: 0x00012C35
		public float maxRecursionDepth
		{
			get
			{
				return RayTracingShader.get_maxRecursionDepthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x00014A47 File Offset: 0x00012C47
		public void SetFloat(int nameID, float val)
		{
			RayTracingShader.SetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x06002319 RID: 8985 RVA: 0x00014A5B File Offset: 0x00012C5B
		public void SetInt(int nameID, int val)
		{
			RayTracingShader.SetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, val);
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x00014A6F File Offset: 0x00012C6F
		public void SetVector(int nameID, Vector4 val)
		{
			this.SetVector_Injected(nameID, ref val);
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00014A7A File Offset: 0x00012C7A
		public void SetMatrix(int nameID, Matrix4x4 val)
		{
			this.SetMatrix_Injected(nameID, ref val);
		}

		// Token: 0x0600231C RID: 8988 RVA: 0x00014A85 File Offset: 0x00012C85
		public void SetFloatArray(int nameID, Il2CppStructArray<float> values)
		{
			RayTracingShader.SetFloatArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600231D RID: 8989 RVA: 0x00014A9E File Offset: 0x00012C9E
		public void SetIntArray(int nameID, Il2CppStructArray<int> values)
		{
			RayTracingShader.SetIntArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600231E RID: 8990 RVA: 0x00014AB7 File Offset: 0x00012CB7
		public void SetVectorArray(int nameID, Il2CppStructArray<Vector4> values)
		{
			RayTracingShader.SetVectorArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x0600231F RID: 8991 RVA: 0x00014AD0 File Offset: 0x00012CD0
		public void SetMatrixArray(int nameID, Il2CppStructArray<Matrix4x4> values)
		{
			RayTracingShader.SetMatrixArrayDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(values));
		}

		// Token: 0x06002320 RID: 8992 RVA: 0x00014AE9 File Offset: 0x00012CE9
		public void SetTexture(int nameID, Texture texture)
		{
			RayTracingShader.SetTextureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(texture));
		}

		// Token: 0x06002321 RID: 8993 RVA: 0x00014B02 File Offset: 0x00012D02
		public void SetBuffer(int nameID, ComputeBuffer buffer)
		{
			RayTracingShader.SetBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002322 RID: 8994 RVA: 0x00014B1B File Offset: 0x00012D1B
		public void SetGraphicsBuffer(int nameID, GraphicsBuffer buffer)
		{
			RayTracingShader.SetGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer));
		}

		// Token: 0x06002323 RID: 8995 RVA: 0x00014B34 File Offset: 0x00012D34
		public void SetConstantComputeBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			RayTracingShader.SetConstantComputeBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002324 RID: 8996 RVA: 0x00014B50 File Offset: 0x00012D50
		public void SetConstantGraphicsBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			RayTracingShader.SetConstantGraphicsBufferDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(buffer), offset, size);
		}

		// Token: 0x06002325 RID: 8997 RVA: 0x00014B6C File Offset: 0x00012D6C
		public void SetAccelerationStructure(int nameID, RayTracingAccelerationStructure accelerationStructure)
		{
			RayTracingShader.SetAccelerationStructureDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, IL2CPP.Il2CppObjectBaseToPtr(accelerationStructure));
		}

		// Token: 0x06002326 RID: 8998 RVA: 0x00014B85 File Offset: 0x00012D85
		public void SetShaderPass(string passName)
		{
			RayTracingShader.SetShaderPassDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(passName));
		}

		// Token: 0x06002327 RID: 8999 RVA: 0x00014B9D File Offset: 0x00012D9D
		public void SetTextureFromGlobal(int nameID, int globalTextureNameID)
		{
			RayTracingShader.SetTextureFromGlobalDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, globalTextureNameID);
		}

		// Token: 0x06002328 RID: 9000 RVA: 0x00014BB1 File Offset: 0x00012DB1
		public void Dispatch(string rayGenFunctionName, int width, int height, int depth, [Optional] Camera camera)
		{
			RayTracingShader.DispatchDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(rayGenFunctionName), width, height, depth, IL2CPP.Il2CppObjectBaseToPtr(camera));
		}

		// Token: 0x06002329 RID: 9001 RVA: 0x00014BD4 File Offset: 0x00012DD4
		public void SetBuffer(int nameID, GraphicsBuffer buffer)
		{
			this.SetGraphicsBuffer(nameID, buffer);
		}

		// Token: 0x0600232A RID: 9002 RVA: 0x00014BE0 File Offset: 0x00012DE0
		public void SetFloat(string name, float val)
		{
			this.SetFloat(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600232B RID: 9003 RVA: 0x00014BF1 File Offset: 0x00012DF1
		public void SetInt(string name, int val)
		{
			this.SetInt(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600232C RID: 9004 RVA: 0x00014C02 File Offset: 0x00012E02
		public void SetVector(string name, Vector4 val)
		{
			this.SetVector(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00014C13 File Offset: 0x00012E13
		public void SetMatrix(string name, Matrix4x4 val)
		{
			this.SetMatrix(Shader.PropertyToID(name), val);
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00014C24 File Offset: 0x00012E24
		public void SetVectorArray(string name, Il2CppStructArray<Vector4> values)
		{
			this.SetVectorArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x00014C35 File Offset: 0x00012E35
		public void SetMatrixArray(string name, Il2CppStructArray<Matrix4x4> values)
		{
			this.SetMatrixArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00014C46 File Offset: 0x00012E46
		public void SetFloats(string name, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002331 RID: 9009 RVA: 0x00014C57 File Offset: 0x00012E57
		public void SetFloats(string name, params float[] values)
		{
			this.SetFloats(name, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00014C66 File Offset: 0x00012E66
		public void SetFloats(int nameID, Il2CppStructArray<float> values)
		{
			this.SetFloatArray(nameID, values);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x00014C72 File Offset: 0x00012E72
		public void SetFloats(int nameID, params float[] values)
		{
			this.SetFloats(nameID, new Il2CppStructArray<float>(values));
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x00014C81 File Offset: 0x00012E81
		public void SetInts(string name, Il2CppStructArray<int> values)
		{
			this.SetIntArray(Shader.PropertyToID(name), values);
		}

		// Token: 0x06002335 RID: 9013 RVA: 0x00014C92 File Offset: 0x00012E92
		public void SetInts(string name, params int[] values)
		{
			this.SetInts(name, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06002336 RID: 9014 RVA: 0x00014CA1 File Offset: 0x00012EA1
		public void SetInts(int nameID, Il2CppStructArray<int> values)
		{
			this.SetIntArray(nameID, values);
		}

		// Token: 0x06002337 RID: 9015 RVA: 0x00014CAD File Offset: 0x00012EAD
		public void SetInts(int nameID, params int[] values)
		{
			this.SetInts(nameID, new Il2CppStructArray<int>(values));
		}

		// Token: 0x06002338 RID: 9016 RVA: 0x00014CBC File Offset: 0x00012EBC
		public void SetBool(string name, bool val)
		{
			this.SetInt(Shader.PropertyToID(name), val ? 1 : 0);
		}

		// Token: 0x06002339 RID: 9017 RVA: 0x00014CD3 File Offset: 0x00012ED3
		public void SetBool(int nameID, bool val)
		{
			this.SetInt(nameID, val ? 1 : 0);
		}

		// Token: 0x0600233A RID: 9018 RVA: 0x00014CE5 File Offset: 0x00012EE5
		public void SetTexture(string name, Texture texture)
		{
			this.SetTexture(Shader.PropertyToID(name), texture);
		}

		// Token: 0x0600233B RID: 9019 RVA: 0x00014CF6 File Offset: 0x00012EF6
		public void SetBuffer(string name, ComputeBuffer buffer)
		{
			this.SetBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x0600233C RID: 9020 RVA: 0x00014D07 File Offset: 0x00012F07
		public void SetBuffer(string name, GraphicsBuffer buffer)
		{
			this.SetBuffer(Shader.PropertyToID(name), buffer);
		}

		// Token: 0x0600233D RID: 9021 RVA: 0x00014D18 File Offset: 0x00012F18
		public void SetConstantBuffer(int nameID, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x0600233E RID: 9022 RVA: 0x00014D27 File Offset: 0x00012F27
		public void SetConstantBuffer(string name, ComputeBuffer buffer, int offset, int size)
		{
			this.SetConstantComputeBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x0600233F RID: 9023 RVA: 0x00014D3B File Offset: 0x00012F3B
		public void SetConstantBuffer(int nameID, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(nameID, buffer, offset, size);
		}

		// Token: 0x06002340 RID: 9024 RVA: 0x00014D4A File Offset: 0x00012F4A
		public void SetConstantBuffer(string name, GraphicsBuffer buffer, int offset, int size)
		{
			this.SetConstantGraphicsBuffer(Shader.PropertyToID(name), buffer, offset, size);
		}

		// Token: 0x06002341 RID: 9025 RVA: 0x00014D5E File Offset: 0x00012F5E
		public void SetAccelerationStructure(string name, RayTracingAccelerationStructure accelerationStructure)
		{
			this.SetAccelerationStructure(Shader.PropertyToID(name), accelerationStructure);
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00014D6F File Offset: 0x00012F6F
		public void SetTextureFromGlobal(string name, string globalTextureName)
		{
			this.SetTextureFromGlobal(Shader.PropertyToID(name), Shader.PropertyToID(globalTextureName));
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x00014D85 File Offset: 0x00012F85
		public void SetVector_Injected(int nameID, ref Vector4 val)
		{
			RayTracingShader.SetVector_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x00014D99 File Offset: 0x00012F99
		public void SetMatrix_Injected(int nameID, ref Matrix4x4 val)
		{
			RayTracingShader.SetMatrix_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), nameID, ref val);
		}

		// Token: 0x04001BF5 RID: 7157
		private static readonly RayTracingShader.get_maxRecursionDepthDelegate get_maxRecursionDepthDelegateField = IL2CPP.ResolveICall<RayTracingShader.get_maxRecursionDepthDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::get_maxRecursionDepth");

		// Token: 0x04001BF6 RID: 7158
		private static readonly RayTracingShader.SetFloatDelegate SetFloatDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetFloat");

		// Token: 0x04001BF7 RID: 7159
		private static readonly RayTracingShader.SetIntDelegate SetIntDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetInt");

		// Token: 0x04001BF8 RID: 7160
		private static readonly RayTracingShader.SetFloatArrayDelegate SetFloatArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetFloatArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetFloatArray");

		// Token: 0x04001BF9 RID: 7161
		private static readonly RayTracingShader.SetIntArrayDelegate SetIntArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetIntArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetIntArray");

		// Token: 0x04001BFA RID: 7162
		private static readonly RayTracingShader.SetVectorArrayDelegate SetVectorArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVectorArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetVectorArray");

		// Token: 0x04001BFB RID: 7163
		private static readonly RayTracingShader.SetMatrixArrayDelegate SetMatrixArrayDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrixArrayDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrixArray");

		// Token: 0x04001BFC RID: 7164
		private static readonly RayTracingShader.SetTextureDelegate SetTextureDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetTexture");

		// Token: 0x04001BFD RID: 7165
		private static readonly RayTracingShader.SetBufferDelegate SetBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetBuffer");

		// Token: 0x04001BFE RID: 7166
		private static readonly RayTracingShader.SetGraphicsBufferDelegate SetGraphicsBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetGraphicsBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetGraphicsBuffer");

		// Token: 0x04001BFF RID: 7167
		private static readonly RayTracingShader.SetConstantComputeBufferDelegate SetConstantComputeBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantComputeBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantComputeBuffer");

		// Token: 0x04001C00 RID: 7168
		private static readonly RayTracingShader.SetConstantGraphicsBufferDelegate SetConstantGraphicsBufferDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetConstantGraphicsBufferDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetConstantGraphicsBuffer");

		// Token: 0x04001C01 RID: 7169
		private static readonly RayTracingShader.SetAccelerationStructureDelegate SetAccelerationStructureDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetAccelerationStructureDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetAccelerationStructure");

		// Token: 0x04001C02 RID: 7170
		private static readonly RayTracingShader.SetShaderPassDelegate SetShaderPassDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetShaderPassDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetShaderPass");

		// Token: 0x04001C03 RID: 7171
		private static readonly RayTracingShader.SetTextureFromGlobalDelegate SetTextureFromGlobalDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetTextureFromGlobalDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetTextureFromGlobal");

		// Token: 0x04001C04 RID: 7172
		private static readonly RayTracingShader.DispatchDelegate DispatchDelegateField = IL2CPP.ResolveICall<RayTracingShader.DispatchDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::Dispatch");

		// Token: 0x04001C05 RID: 7173
		private static readonly RayTracingShader.SetVector_InjectedDelegate SetVector_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetVector_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetVector_Injected");

		// Token: 0x04001C06 RID: 7174
		private static readonly RayTracingShader.SetMatrix_InjectedDelegate SetMatrix_InjectedDelegateField = IL2CPP.ResolveICall<RayTracingShader.SetMatrix_InjectedDelegate>("UnityEngine.Experimental.Rendering.RayTracingShader::SetMatrix_Injected");

		// Token: 0x02000D33 RID: 3379
		// (Invoke) Token: 0x06003846 RID: 14406
		private delegate float get_maxRecursionDepthDelegate(IntPtr @this);

		// Token: 0x02000D34 RID: 3380
		// (Invoke) Token: 0x06003848 RID: 14408
		private delegate void SetFloatDelegate(IntPtr @this, int nameID, float val);

		// Token: 0x02000D35 RID: 3381
		// (Invoke) Token: 0x0600384A RID: 14410
		private delegate void SetIntDelegate(IntPtr @this, int nameID, int val);

		// Token: 0x02000D36 RID: 3382
		// (Invoke) Token: 0x0600384C RID: 14412
		private delegate void SetFloatArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000D37 RID: 3383
		// (Invoke) Token: 0x0600384E RID: 14414
		private delegate void SetIntArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000D38 RID: 3384
		// (Invoke) Token: 0x06003850 RID: 14416
		private delegate void SetVectorArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000D39 RID: 3385
		// (Invoke) Token: 0x06003852 RID: 14418
		private delegate void SetMatrixArrayDelegate(IntPtr @this, int nameID, IntPtr values);

		// Token: 0x02000D3A RID: 3386
		// (Invoke) Token: 0x06003854 RID: 14420
		private delegate void SetTextureDelegate(IntPtr @this, int nameID, IntPtr texture);

		// Token: 0x02000D3B RID: 3387
		// (Invoke) Token: 0x06003856 RID: 14422
		private delegate void SetBufferDelegate(IntPtr @this, int nameID, IntPtr buffer);

		// Token: 0x02000D3C RID: 3388
		// (Invoke) Token: 0x06003858 RID: 14424
		private delegate void SetGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer);

		// Token: 0x02000D3D RID: 3389
		// (Invoke) Token: 0x0600385A RID: 14426
		private delegate void SetConstantComputeBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000D3E RID: 3390
		// (Invoke) Token: 0x0600385C RID: 14428
		private delegate void SetConstantGraphicsBufferDelegate(IntPtr @this, int nameID, IntPtr buffer, int offset, int size);

		// Token: 0x02000D3F RID: 3391
		// (Invoke) Token: 0x0600385E RID: 14430
		private delegate void SetAccelerationStructureDelegate(IntPtr @this, int nameID, IntPtr accelerationStructure);

		// Token: 0x02000D40 RID: 3392
		// (Invoke) Token: 0x06003860 RID: 14432
		private delegate void SetShaderPassDelegate(IntPtr @this, IntPtr passName);

		// Token: 0x02000D41 RID: 3393
		// (Invoke) Token: 0x06003862 RID: 14434
		private delegate void SetTextureFromGlobalDelegate(IntPtr @this, int nameID, int globalTextureNameID);

		// Token: 0x02000D42 RID: 3394
		// (Invoke) Token: 0x06003864 RID: 14436
		private delegate void DispatchDelegate(IntPtr @this, IntPtr rayGenFunctionName, int width, int height, int depth, IntPtr camera);

		// Token: 0x02000D43 RID: 3395
		// (Invoke) Token: 0x06003866 RID: 14438
		private delegate void SetVector_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);

		// Token: 0x02000D44 RID: 3396
		// (Invoke) Token: 0x06003868 RID: 14440
		private delegate void SetMatrix_InjectedDelegate(IntPtr @this, int nameID, IntPtr val);
	}
}
