using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Playables;

namespace UnityEngine.Experimental.Playables
{
	// Token: 0x02000166 RID: 358
	[StructLayout(2)]
	public struct MaterialEffectPlayable
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x0005F994 File Offset: 0x0005DB94
		// Note: this type is marked as 'beforefieldinit'.
		static MaterialEffectPlayable()
		{
			Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Experimental.Playables", "MaterialEffectPlayable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr);
			MaterialEffectPlayable.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, "m_Handle");
			MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100665268);
			MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, 100665269);
			MaterialEffectPlayable.GetMaterialInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetMaterialInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetMaterialInternal");
			MaterialEffectPlayable.SetMaterialInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetMaterialInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetMaterialInternal");
			MaterialEffectPlayable.GetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.GetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::GetPassInternal");
			MaterialEffectPlayable.SetPassInternalDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.SetPassInternalDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::SetPassInternal");
			MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::InternalCreateMaterialEffectPlayable");
			MaterialEffectPlayable.ValidateTypeDelegateField = IL2CPP.ResolveICall<MaterialEffectPlayable.ValidateTypeDelegate>("UnityEngine.Experimental.Playables.MaterialEffectPlayable::ValidateType");
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0005FA5C File Offset: 0x0005DC5C
		[CallerCount(0)]
		public unsafe UnityEngine.Playables.PlayableHandle GetHandle()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0005FA8C File Offset: 0x0005DC8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 83135, XrefRangeEnd = 83143, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(MaterialEffectPlayable other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MaterialEffectPlayable.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0000EC6A File Offset: 0x0000CE6A
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaterialEffectPlayable>.NativeClassPtr, ref this));
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0005FACC File Offset: 0x0005DCCC
		public static MaterialEffectPlayable Create(UnityEngine.Playables.PlayableGraph graph, Material material, [Optional] int pass)
		{
			UnityEngine.Playables.PlayableHandle playableHandle = MaterialEffectPlayable.CreateHandle(graph, material, pass);
			return new MaterialEffectPlayable(playableHandle);
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0005FAF0 File Offset: 0x0005DCF0
		public static UnityEngine.Playables.PlayableHandle CreateHandle(UnityEngine.Playables.PlayableGraph graph, Material material, int pass)
		{
			UnityEngine.Playables.PlayableHandle @null = UnityEngine.Playables.PlayableHandle.Null;
			bool flag = !MaterialEffectPlayable.InternalCreateMaterialEffectPlayable(ref graph, material, pass, ref @null);
			UnityEngine.Playables.PlayableHandle playableHandle;
			if (flag)
			{
				playableHandle = UnityEngine.Playables.PlayableHandle.Null;
			}
			else
			{
				playableHandle = @null;
			}
			return playableHandle;
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0005FB24 File Offset: 0x0005DD24
		public static implicit operator UnityEngine.Playables.Playable(MaterialEffectPlayable playable)
		{
			return new UnityEngine.Playables.Playable(playable.GetHandle());
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0005FB44 File Offset: 0x0005DD44
		public static explicit operator MaterialEffectPlayable(UnityEngine.Playables.Playable playable)
		{
			return new MaterialEffectPlayable(playable.GetHandle());
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x0005FB64 File Offset: 0x0005DD64
		public Material GetMaterial()
		{
			return MaterialEffectPlayable.GetMaterialInternal(ref this.m_Handle);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0000EC7C File Offset: 0x0000CE7C
		public void SetMaterial(Material value)
		{
			MaterialEffectPlayable.SetMaterialInternal(ref this.m_Handle, value);
		}

		// Token: 0x06001AD0 RID: 6864 RVA: 0x0005FB84 File Offset: 0x0005DD84
		public int GetPass()
		{
			return MaterialEffectPlayable.GetPassInternal(ref this.m_Handle);
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x0000EC8C File Offset: 0x0000CE8C
		public void SetPass(int value)
		{
			MaterialEffectPlayable.SetPassInternal(ref this.m_Handle, value);
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x0005FBA4 File Offset: 0x0005DDA4
		public static Material GetMaterialInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			IntPtr intPtr = MaterialEffectPlayable.GetMaterialInternalDelegateField(ref hdl);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Material>(intPtr2) : null;
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x0000EC9C File Offset: 0x0000CE9C
		public static void SetMaterialInternal(ref UnityEngine.Playables.PlayableHandle hdl, Material material)
		{
			MaterialEffectPlayable.SetMaterialInternalDelegateField(ref hdl, IL2CPP.Il2CppObjectBaseToPtr(material));
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x0000ECAF File Offset: 0x0000CEAF
		public static int GetPassInternal(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return MaterialEffectPlayable.GetPassInternalDelegateField(ref hdl);
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x0000ECBC File Offset: 0x0000CEBC
		public static void SetPassInternal(ref UnityEngine.Playables.PlayableHandle hdl, int pass)
		{
			MaterialEffectPlayable.SetPassInternalDelegateField(ref hdl, pass);
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x0000ECCA File Offset: 0x0000CECA
		public static bool InternalCreateMaterialEffectPlayable(ref UnityEngine.Playables.PlayableGraph graph, Material material, int pass, ref UnityEngine.Playables.PlayableHandle handle)
		{
			return MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegateField(ref graph, IL2CPP.Il2CppObjectBaseToPtr(material), pass, ref handle);
		}

		// Token: 0x06001AD7 RID: 6871 RVA: 0x0000ECDF File Offset: 0x0000CEDF
		public static bool ValidateType(ref UnityEngine.Playables.PlayableHandle hdl)
		{
			return MaterialEffectPlayable.ValidateTypeDelegateField(ref hdl);
		}

		// Token: 0x04001425 RID: 5157
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001426 RID: 5158
		private static readonly IntPtr NativeMethodInfoPtr_GetHandle_Public_Virtual_Final_New_PlayableHandle_0;

		// Token: 0x04001427 RID: 5159
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MaterialEffectPlayable_0;

		// Token: 0x04001428 RID: 5160
		[FieldOffset(0)]
		public UnityEngine.Playables.PlayableHandle m_Handle;

		// Token: 0x04001429 RID: 5161
		private static readonly MaterialEffectPlayable.GetMaterialInternalDelegate GetMaterialInternalDelegateField;

		// Token: 0x0400142A RID: 5162
		private static readonly MaterialEffectPlayable.SetMaterialInternalDelegate SetMaterialInternalDelegateField;

		// Token: 0x0400142B RID: 5163
		private static readonly MaterialEffectPlayable.GetPassInternalDelegate GetPassInternalDelegateField;

		// Token: 0x0400142C RID: 5164
		private static readonly MaterialEffectPlayable.SetPassInternalDelegate SetPassInternalDelegateField;

		// Token: 0x0400142D RID: 5165
		private static readonly MaterialEffectPlayable.InternalCreateMaterialEffectPlayableDelegate InternalCreateMaterialEffectPlayableDelegateField;

		// Token: 0x0400142E RID: 5166
		private static readonly MaterialEffectPlayable.ValidateTypeDelegate ValidateTypeDelegateField;

		// Token: 0x02000A0C RID: 2572
		// (Invoke) Token: 0x0600323E RID: 12862
		private delegate IntPtr GetMaterialInternalDelegate(IntPtr hdl);

		// Token: 0x02000A0D RID: 2573
		// (Invoke) Token: 0x06003240 RID: 12864
		private delegate void SetMaterialInternalDelegate(IntPtr hdl, IntPtr material);

		// Token: 0x02000A0E RID: 2574
		// (Invoke) Token: 0x06003242 RID: 12866
		private delegate int GetPassInternalDelegate(IntPtr hdl);

		// Token: 0x02000A0F RID: 2575
		// (Invoke) Token: 0x06003244 RID: 12868
		private delegate void SetPassInternalDelegate(IntPtr hdl, int pass);

		// Token: 0x02000A10 RID: 2576
		// (Invoke) Token: 0x06003246 RID: 12870
		private delegate bool InternalCreateMaterialEffectPlayableDelegate(IntPtr graph, IntPtr material, int pass, IntPtr handle);

		// Token: 0x02000A11 RID: 2577
		// (Invoke) Token: 0x06003248 RID: 12872
		private delegate bool ValidateTypeDelegate(IntPtr hdl);
	}
}
