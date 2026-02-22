using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using UnityEngine.Rendering;

namespace UnityEngine
{
	// Token: 0x0200023D RID: 573
	public sealed class ShaderVariantCollection : Object
	{
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001F33 RID: 7987 RVA: 0x00011F3B File Offset: 0x0001013B
		public int shaderCount
		{
			get
			{
				return ShaderVariantCollection.get_shaderCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001F34 RID: 7988 RVA: 0x00011F4D File Offset: 0x0001014D
		public int variantCount
		{
			get
			{
				return ShaderVariantCollection.get_variantCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001F35 RID: 7989 RVA: 0x00011F5F File Offset: 0x0001015F
		public bool isWarmedUp
		{
			get
			{
				return ShaderVariantCollection.get_isWarmedUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x06001F36 RID: 7990 RVA: 0x00011F71 File Offset: 0x00010171
		public bool AddVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.AddVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06001F37 RID: 7991 RVA: 0x00011F90 File Offset: 0x00010190
		public bool RemoveVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.RemoveVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06001F38 RID: 7992 RVA: 0x00011FAF File Offset: 0x000101AF
		public bool ContainsVariant(Shader shader, UnityEngine.Rendering.PassType passType, Il2CppStringArray keywords)
		{
			return ShaderVariantCollection.ContainsVariantDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(shader), passType, IL2CPP.Il2CppObjectBaseToPtr(keywords));
		}

		// Token: 0x06001F39 RID: 7993 RVA: 0x00011FCE File Offset: 0x000101CE
		public void Clear()
		{
			ShaderVariantCollection.ClearDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001F3A RID: 7994 RVA: 0x00011FE0 File Offset: 0x000101E0
		public void WarmUp()
		{
			ShaderVariantCollection.WarmUpDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001F3B RID: 7995 RVA: 0x00011FF2 File Offset: 0x000101F2
		public static void Internal_Create(ShaderVariantCollection svc)
		{
			ShaderVariantCollection.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(svc));
		}

		// Token: 0x040018AA RID: 6314
		private static readonly ShaderVariantCollection.get_shaderCountDelegate get_shaderCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_shaderCountDelegate>("UnityEngine.ShaderVariantCollection::get_shaderCount");

		// Token: 0x040018AB RID: 6315
		private static readonly ShaderVariantCollection.get_variantCountDelegate get_variantCountDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_variantCountDelegate>("UnityEngine.ShaderVariantCollection::get_variantCount");

		// Token: 0x040018AC RID: 6316
		private static readonly ShaderVariantCollection.get_isWarmedUpDelegate get_isWarmedUpDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.get_isWarmedUpDelegate>("UnityEngine.ShaderVariantCollection::get_isWarmedUp");

		// Token: 0x040018AD RID: 6317
		private static readonly ShaderVariantCollection.AddVariantDelegate AddVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.AddVariantDelegate>("UnityEngine.ShaderVariantCollection::AddVariant");

		// Token: 0x040018AE RID: 6318
		private static readonly ShaderVariantCollection.RemoveVariantDelegate RemoveVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.RemoveVariantDelegate>("UnityEngine.ShaderVariantCollection::RemoveVariant");

		// Token: 0x040018AF RID: 6319
		private static readonly ShaderVariantCollection.ContainsVariantDelegate ContainsVariantDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ContainsVariantDelegate>("UnityEngine.ShaderVariantCollection::ContainsVariant");

		// Token: 0x040018B0 RID: 6320
		private static readonly ShaderVariantCollection.ClearDelegate ClearDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.ClearDelegate>("UnityEngine.ShaderVariantCollection::Clear");

		// Token: 0x040018B1 RID: 6321
		private static readonly ShaderVariantCollection.WarmUpDelegate WarmUpDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.WarmUpDelegate>("UnityEngine.ShaderVariantCollection::WarmUp");

		// Token: 0x040018B2 RID: 6322
		private static readonly ShaderVariantCollection.Internal_CreateDelegate Internal_CreateDelegateField = IL2CPP.ResolveICall<ShaderVariantCollection.Internal_CreateDelegate>("UnityEngine.ShaderVariantCollection::Internal_Create");

		// Token: 0x02000C1D RID: 3101
		// (Invoke) Token: 0x06003628 RID: 13864
		private delegate int get_shaderCountDelegate(IntPtr @this);

		// Token: 0x02000C1E RID: 3102
		// (Invoke) Token: 0x0600362A RID: 13866
		private delegate int get_variantCountDelegate(IntPtr @this);

		// Token: 0x02000C1F RID: 3103
		// (Invoke) Token: 0x0600362C RID: 13868
		private delegate bool get_isWarmedUpDelegate(IntPtr @this);

		// Token: 0x02000C20 RID: 3104
		// (Invoke) Token: 0x0600362E RID: 13870
		private delegate bool AddVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000C21 RID: 3105
		// (Invoke) Token: 0x06003630 RID: 13872
		private delegate bool RemoveVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000C22 RID: 3106
		// (Invoke) Token: 0x06003632 RID: 13874
		private delegate bool ContainsVariantDelegate(IntPtr @this, IntPtr shader, UnityEngine.Rendering.PassType passType, IntPtr keywords);

		// Token: 0x02000C23 RID: 3107
		// (Invoke) Token: 0x06003634 RID: 13876
		private delegate void ClearDelegate(IntPtr @this);

		// Token: 0x02000C24 RID: 3108
		// (Invoke) Token: 0x06003636 RID: 13878
		private delegate void WarmUpDelegate(IntPtr @this);

		// Token: 0x02000C25 RID: 3109
		// (Invoke) Token: 0x06003638 RID: 13880
		private delegate void Internal_CreateDelegate(IntPtr svc);
	}
}
