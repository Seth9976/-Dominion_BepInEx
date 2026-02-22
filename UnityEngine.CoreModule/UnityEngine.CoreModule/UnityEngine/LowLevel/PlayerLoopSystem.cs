using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.LowLevel
{
	// Token: 0x0200011E RID: 286
	public sealed class PlayerLoopSystem : ValueType
	{
		// Token: 0x06001711 RID: 5905 RVA: 0x00057164 File Offset: 0x00055364
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoopSystem()
		{
			Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoopSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr);
			PlayerLoopSystem.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "type");
			PlayerLoopSystem.NativeFieldInfoPtr_subSystemList = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "subSystemList");
			PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "updateDelegate");
			PlayerLoopSystem.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "updateFunction");
			PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "loopConditionFunction");
			PlayerLoopSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, 100665020);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0005720C File Offset: 0x0005540C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 81527, XrefRangeEnd = 81528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0000CE3A File Offset: 0x0000B03A
		public PlayerLoopSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0000CE43 File Offset: 0x0000B043
		public PlayerLoopSystem()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr))
		{
		}

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x00057248 File Offset: 0x00055448
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x0000CE55 File Offset: 0x0000B055
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001717 RID: 5911 RVA: 0x00057278 File Offset: 0x00055478
		// (set) Token: 0x06001718 RID: 5912 RVA: 0x0000CE74 File Offset: 0x0000B074
		public unsafe Il2CppReferenceArray<PlayerLoopSystem> subSystemList
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_subSystemList);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<PlayerLoopSystem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_subSystemList), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001719 RID: 5913 RVA: 0x000572A8 File Offset: 0x000554A8
		// (set) Token: 0x0600171A RID: 5914 RVA: 0x0000CE93 File Offset: 0x0000B093
		public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x000572D8 File Offset: 0x000554D8
		// (set) Token: 0x0600171C RID: 5916 RVA: 0x0000CEB2 File Offset: 0x0000B0B2
		public unsafe IntPtr updateFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_updateFunction)) = value;
			}
		}

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00057300 File Offset: 0x00055500
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x0000CECD File Offset: 0x0000B0CD
		public unsafe IntPtr loopConditionFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystem.NativeFieldInfoPtr_loopConditionFunction)) = value;
			}
		}

		// Token: 0x040010D2 RID: 4306
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040010D3 RID: 4307
		private static readonly IntPtr NativeFieldInfoPtr_subSystemList;

		// Token: 0x040010D4 RID: 4308
		private static readonly IntPtr NativeFieldInfoPtr_updateDelegate;

		// Token: 0x040010D5 RID: 4309
		private static readonly IntPtr NativeFieldInfoPtr_updateFunction;

		// Token: 0x040010D6 RID: 4310
		private static readonly IntPtr NativeFieldInfoPtr_loopConditionFunction;

		// Token: 0x040010D7 RID: 4311
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x020008DA RID: 2266
		public sealed class UpdateFunction : MulticastDelegate
		{
			// Token: 0x06002FB2 RID: 12210 RVA: 0x00015CED File Offset: 0x00013EED
			// Note: this type is marked as 'beforefieldinit'.
			static UpdateFunction()
			{
				Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlayerLoopSystem>.NativeClassPtr, "UpdateFunction");
				PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr, 100665021);
				PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr, 100665022);
			}

			// Token: 0x06002FB3 RID: 12211 RVA: 0x0006DA08 File Offset: 0x0006BC08
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UpdateFunction(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystem.UpdateFunction>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FB4 RID: 12212 RVA: 0x0006DA64 File Offset: 0x0006BC64
			[CallerCount(149)]
			[CachedScanResults(RefRangeStart = 59293, RefRangeEnd = 59442, XrefRangeStart = 59293, XrefRangeEnd = 59442, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoopSystem.UpdateFunction.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002FB5 RID: 12213 RVA: 0x00015D2B File Offset: 0x00013F2B
			public UpdateFunction(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002FB6 RID: 12214 RVA: 0x00015D34 File Offset: 0x00013F34
			public static implicit operator PlayerLoopSystem.UpdateFunction(Action A_0)
			{
				return DelegateSupport.ConvertDelegate<PlayerLoopSystem.UpdateFunction>(A_0);
			}

			// Token: 0x06002FB7 RID: 12215 RVA: 0x00015D3C File Offset: 0x00013F3C
			public static PlayerLoopSystem.UpdateFunction operator +(PlayerLoopSystem.UpdateFunction A_0, PlayerLoopSystem.UpdateFunction A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PlayerLoopSystem.UpdateFunction>();
			}

			// Token: 0x06002FB8 RID: 12216 RVA: 0x00015D4A File Offset: 0x00013F4A
			public static PlayerLoopSystem.UpdateFunction operator -(PlayerLoopSystem.UpdateFunction A_0, PlayerLoopSystem.UpdateFunction A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PlayerLoopSystem.UpdateFunction>();
				}
				return delegate2;
			}

			// Token: 0x04001D01 RID: 7425
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001D02 RID: 7426
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_0;
		}
	}
}
