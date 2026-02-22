using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.LowLevel
{
	// Token: 0x0200011D RID: 285
	public sealed class PlayerLoopSystemInternal : ValueType
	{
		// Token: 0x06001704 RID: 5892 RVA: 0x00056FF8 File Offset: 0x000551F8
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoopSystemInternal()
		{
			Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.LowLevel", "PlayerLoopSystemInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr);
			PlayerLoopSystemInternal.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "type");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "updateDelegate");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "updateFunction");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "loopConditionFunction");
			PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr, "numSubSystems");
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0000CD90 File Offset: 0x0000AF90
		public PlayerLoopSystemInternal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0000CD99 File Offset: 0x0000AF99
		public PlayerLoopSystemInternal()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoopSystemInternal>.NativeClassPtr))
		{
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0005708C File Offset: 0x0005528C
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x0000CDAB File Offset: 0x0000AFAB
		public unsafe Type type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x000570BC File Offset: 0x000552BC
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x0000CDCA File Offset: 0x0000AFCA
		public unsafe PlayerLoopSystem.UpdateFunction updateDelegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerLoopSystem.UpdateFunction>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateDelegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x000570EC File Offset: 0x000552EC
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x0000CDE9 File Offset: 0x0000AFE9
		public unsafe IntPtr updateFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_updateFunction)) = value;
			}
		}

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x00057114 File Offset: 0x00055314
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x0000CE04 File Offset: 0x0000B004
		public unsafe IntPtr loopConditionFunction
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_loopConditionFunction)) = value;
			}
		}

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x0600170F RID: 5903 RVA: 0x0005713C File Offset: 0x0005533C
		// (set) Token: 0x06001710 RID: 5904 RVA: 0x0000CE1F File Offset: 0x0000B01F
		public unsafe int numSubSystems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerLoopSystemInternal.NativeFieldInfoPtr_numSubSystems)) = value;
			}
		}

		// Token: 0x040010CD RID: 4301
		private static readonly IntPtr NativeFieldInfoPtr_type;

		// Token: 0x040010CE RID: 4302
		private static readonly IntPtr NativeFieldInfoPtr_updateDelegate;

		// Token: 0x040010CF RID: 4303
		private static readonly IntPtr NativeFieldInfoPtr_updateFunction;

		// Token: 0x040010D0 RID: 4304
		private static readonly IntPtr NativeFieldInfoPtr_loopConditionFunction;

		// Token: 0x040010D1 RID: 4305
		private static readonly IntPtr NativeFieldInfoPtr_numSubSystems;
	}
}
