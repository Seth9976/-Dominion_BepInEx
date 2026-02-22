using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.VFX
{
	// Token: 0x02000006 RID: 6
	public sealed class VFXSpawnerState : Object
	{
		// Token: 0x06000083 RID: 131 RVA: 0x00003D7C File Offset: 0x00001F7C
		// Note: this type is marked as 'beforefieldinit'.
		static VFXSpawnerState()
		{
			Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.VFXModule.dll", "UnityEngine.VFX", "VFXSpawnerState");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr);
			VFXSpawnerState.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "m_Ptr");
			VFXSpawnerState.NativeFieldInfoPtr_m_Owner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, "m_Owner");
			VFXSpawnerState.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663311);
			VFXSpawnerState.NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663312);
			VFXSpawnerState.NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663313);
			VFXSpawnerState.NativeMethodInfoPtr_Release_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663314);
			VFXSpawnerState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663315);
			VFXSpawnerState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663316);
			VFXSpawnerState.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr, 100663317);
			VFXSpawnerState.Internal_CreateDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.Internal_CreateDelegate>("UnityEngine.VFX.VFXSpawnerState::Internal_Create");
			VFXSpawnerState.get_newLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_newLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::get_newLoop");
			VFXSpawnerState.get_loopStateDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_loopStateDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopState");
			VFXSpawnerState.set_loopStateDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_loopStateDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopState");
			VFXSpawnerState.get_spawnCountDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_spawnCountDelegate>("UnityEngine.VFX.VFXSpawnerState::get_spawnCount");
			VFXSpawnerState.set_spawnCountDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_spawnCountDelegate>("UnityEngine.VFX.VFXSpawnerState::set_spawnCount");
			VFXSpawnerState.get_deltaTimeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_deltaTimeDelegate>("UnityEngine.VFX.VFXSpawnerState::get_deltaTime");
			VFXSpawnerState.set_deltaTimeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_deltaTimeDelegate>("UnityEngine.VFX.VFXSpawnerState::set_deltaTime");
			VFXSpawnerState.get_totalTimeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_totalTimeDelegate>("UnityEngine.VFX.VFXSpawnerState::get_totalTime");
			VFXSpawnerState.set_totalTimeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_totalTimeDelegate>("UnityEngine.VFX.VFXSpawnerState::set_totalTime");
			VFXSpawnerState.get_delayBeforeLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_delayBeforeLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::get_delayBeforeLoop");
			VFXSpawnerState.set_delayBeforeLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_delayBeforeLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::set_delayBeforeLoop");
			VFXSpawnerState.get_loopDurationDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_loopDurationDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopDuration");
			VFXSpawnerState.set_loopDurationDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_loopDurationDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopDuration");
			VFXSpawnerState.get_delayAfterLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_delayAfterLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::get_delayAfterLoop");
			VFXSpawnerState.set_delayAfterLoopDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_delayAfterLoopDelegate>("UnityEngine.VFX.VFXSpawnerState::set_delayAfterLoop");
			VFXSpawnerState.get_loopIndexDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_loopIndexDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopIndex");
			VFXSpawnerState.set_loopIndexDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_loopIndexDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopIndex");
			VFXSpawnerState.get_loopCountDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_loopCountDelegate>("UnityEngine.VFX.VFXSpawnerState::get_loopCount");
			VFXSpawnerState.set_loopCountDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.set_loopCountDelegate>("UnityEngine.VFX.VFXSpawnerState::set_loopCount");
			VFXSpawnerState.get_vfxEventAttributeDelegateField = IL2CPP.ResolveICall<VFXSpawnerState.get_vfxEventAttributeDelegate>("UnityEngine.VFX.VFXSpawnerState::get_vfxEventAttribute");
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00003F9C File Offset: 0x0000219C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 39185, RefRangeEnd = 39187, XrefRangeStart = 39185, XrefRangeEnd = 39187, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VFXSpawnerState(IntPtr ptr, bool owner)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VFXSpawnerState>.NativeClassPtr))
		{
			IntPtr* ptr2;
			checked
			{
				ptr2 = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
			}
			ptr2[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref owner;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00003FF4 File Offset: 0x000021F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158160, XrefRangeEnd = 158165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static VFXSpawnerState CreateSpawnerStateWrapper()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<VFXSpawnerState>(intPtr3) : null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00004028 File Offset: 0x00002228
		[CallerCount(0)]
		public unsafe void SetWrapValue(IntPtr ptr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00004068 File Offset: 0x00002268
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 158169, RefRangeEnd = 158171, XrefRangeStart = 158165, XrefRangeEnd = 158169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_Release_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000409C File Offset: 0x0000229C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158171, XrefRangeEnd = 158175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void Finalize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000040D0 File Offset: 0x000022D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158175, XrefRangeEnd = 158180, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00004104 File Offset: 0x00002304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158180, XrefRangeEnd = 158182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Internal_Destroy(IntPtr ptr)
		{
			checked
			{
				IntPtr* ptr2 = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr2 = ref ptr;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VFXSpawnerState.NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0, 0, (void**)ptr2, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000250A File Offset: 0x0000070A
		public VFXSpawnerState(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600008C RID: 140 RVA: 0x00004138 File Offset: 0x00002338
		// (set) Token: 0x0600008D RID: 141 RVA: 0x00002513 File Offset: 0x00000713
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600008E RID: 142 RVA: 0x00004160 File Offset: 0x00002360
		// (set) Token: 0x0600008F RID: 143 RVA: 0x0000252E File Offset: 0x0000072E
		public unsafe bool m_Owner
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_Owner);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VFXSpawnerState.NativeFieldInfoPtr_m_Owner)) = value;
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002549 File Offset: 0x00000749
		public static IntPtr Internal_Create()
		{
			return VFXSpawnerState.Internal_CreateDelegateField();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00004188 File Offset: 0x00002388
		public IntPtr GetPtr()
		{
			return this.m_Ptr;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000092 RID: 146 RVA: 0x000041A0 File Offset: 0x000023A0
		// (set) Token: 0x06000093 RID: 147 RVA: 0x00002555 File Offset: 0x00000755
		public bool playing
		{
			get
			{
				return this.loopState == VFXSpawnerLoopState.Looping;
			}
			set
			{
				this.loopState = (value ? VFXSpawnerLoopState.Looping : VFXSpawnerLoopState.Finished);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00002566 File Offset: 0x00000766
		public bool newLoop
		{
			get
			{
				return VFXSpawnerState.get_newLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00002578 File Offset: 0x00000778
		// (set) Token: 0x06000096 RID: 150 RVA: 0x0000258A File Offset: 0x0000078A
		public VFXSpawnerLoopState loopState
		{
			get
			{
				return VFXSpawnerState.get_loopStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_loopStateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000259D File Offset: 0x0000079D
		// (set) Token: 0x06000098 RID: 152 RVA: 0x000025AF File Offset: 0x000007AF
		public float spawnCount
		{
			get
			{
				return VFXSpawnerState.get_spawnCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_spawnCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000099 RID: 153 RVA: 0x000025C2 File Offset: 0x000007C2
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000025D4 File Offset: 0x000007D4
		public float deltaTime
		{
			get
			{
				return VFXSpawnerState.get_deltaTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_deltaTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000025E7 File Offset: 0x000007E7
		// (set) Token: 0x0600009C RID: 156 RVA: 0x000025F9 File Offset: 0x000007F9
		public float totalTime
		{
			get
			{
				return VFXSpawnerState.get_totalTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_totalTimeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000260C File Offset: 0x0000080C
		// (set) Token: 0x0600009E RID: 158 RVA: 0x0000261E File Offset: 0x0000081E
		public float delayBeforeLoop
		{
			get
			{
				return VFXSpawnerState.get_delayBeforeLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_delayBeforeLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00002631 File Offset: 0x00000831
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00002643 File Offset: 0x00000843
		public float loopDuration
		{
			get
			{
				return VFXSpawnerState.get_loopDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_loopDurationDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00002656 File Offset: 0x00000856
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00002668 File Offset: 0x00000868
		public float delayAfterLoop
		{
			get
			{
				return VFXSpawnerState.get_delayAfterLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_delayAfterLoopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000267B File Offset: 0x0000087B
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x0000268D File Offset: 0x0000088D
		public int loopIndex
		{
			get
			{
				return VFXSpawnerState.get_loopIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_loopIndexDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000026A0 File Offset: 0x000008A0
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x000026B2 File Offset: 0x000008B2
		public int loopCount
		{
			get
			{
				return VFXSpawnerState.get_loopCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				VFXSpawnerState.set_loopCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000041BC File Offset: 0x000023BC
		public VFXEventAttribute vfxEventAttribute
		{
			get
			{
				IntPtr intPtr = VFXSpawnerState.get_vfxEventAttributeDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VFXEventAttribute>(intPtr2) : null;
			}
		}

		// Token: 0x04000043 RID: 67
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000044 RID: 68
		private static readonly IntPtr NativeFieldInfoPtr_m_Owner;

		// Token: 0x04000045 RID: 69
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IntPtr_Boolean_0;

		// Token: 0x04000046 RID: 70
		private static readonly IntPtr NativeMethodInfoPtr_CreateSpawnerStateWrapper_Internal_Static_VFXSpawnerState_0;

		// Token: 0x04000047 RID: 71
		private static readonly IntPtr NativeMethodInfoPtr_SetWrapValue_Internal_Void_IntPtr_0;

		// Token: 0x04000048 RID: 72
		private static readonly IntPtr NativeMethodInfoPtr_Release_Private_Void_0;

		// Token: 0x04000049 RID: 73
		private static readonly IntPtr NativeMethodInfoPtr_Finalize_Protected_Virtual_Void_0;

		// Token: 0x0400004A RID: 74
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x0400004B RID: 75
		private static readonly IntPtr NativeMethodInfoPtr_Internal_Destroy_Private_Static_Void_IntPtr_0;

		// Token: 0x0400004C RID: 76
		private static readonly VFXSpawnerState.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x0400004D RID: 77
		private static readonly VFXSpawnerState.get_newLoopDelegate get_newLoopDelegateField;

		// Token: 0x0400004E RID: 78
		private static readonly VFXSpawnerState.get_loopStateDelegate get_loopStateDelegateField;

		// Token: 0x0400004F RID: 79
		private static readonly VFXSpawnerState.set_loopStateDelegate set_loopStateDelegateField;

		// Token: 0x04000050 RID: 80
		private static readonly VFXSpawnerState.get_spawnCountDelegate get_spawnCountDelegateField;

		// Token: 0x04000051 RID: 81
		private static readonly VFXSpawnerState.set_spawnCountDelegate set_spawnCountDelegateField;

		// Token: 0x04000052 RID: 82
		private static readonly VFXSpawnerState.get_deltaTimeDelegate get_deltaTimeDelegateField;

		// Token: 0x04000053 RID: 83
		private static readonly VFXSpawnerState.set_deltaTimeDelegate set_deltaTimeDelegateField;

		// Token: 0x04000054 RID: 84
		private static readonly VFXSpawnerState.get_totalTimeDelegate get_totalTimeDelegateField;

		// Token: 0x04000055 RID: 85
		private static readonly VFXSpawnerState.set_totalTimeDelegate set_totalTimeDelegateField;

		// Token: 0x04000056 RID: 86
		private static readonly VFXSpawnerState.get_delayBeforeLoopDelegate get_delayBeforeLoopDelegateField;

		// Token: 0x04000057 RID: 87
		private static readonly VFXSpawnerState.set_delayBeforeLoopDelegate set_delayBeforeLoopDelegateField;

		// Token: 0x04000058 RID: 88
		private static readonly VFXSpawnerState.get_loopDurationDelegate get_loopDurationDelegateField;

		// Token: 0x04000059 RID: 89
		private static readonly VFXSpawnerState.set_loopDurationDelegate set_loopDurationDelegateField;

		// Token: 0x0400005A RID: 90
		private static readonly VFXSpawnerState.get_delayAfterLoopDelegate get_delayAfterLoopDelegateField;

		// Token: 0x0400005B RID: 91
		private static readonly VFXSpawnerState.set_delayAfterLoopDelegate set_delayAfterLoopDelegateField;

		// Token: 0x0400005C RID: 92
		private static readonly VFXSpawnerState.get_loopIndexDelegate get_loopIndexDelegateField;

		// Token: 0x0400005D RID: 93
		private static readonly VFXSpawnerState.set_loopIndexDelegate set_loopIndexDelegateField;

		// Token: 0x0400005E RID: 94
		private static readonly VFXSpawnerState.get_loopCountDelegate get_loopCountDelegateField;

		// Token: 0x0400005F RID: 95
		private static readonly VFXSpawnerState.set_loopCountDelegate set_loopCountDelegateField;

		// Token: 0x04000060 RID: 96
		private static readonly VFXSpawnerState.get_vfxEventAttributeDelegate get_vfxEventAttributeDelegateField;

		// Token: 0x02000048 RID: 72
		// (Invoke) Token: 0x060001AC RID: 428
		private delegate IntPtr Internal_CreateDelegate();

		// Token: 0x02000049 RID: 73
		// (Invoke) Token: 0x060001AE RID: 430
		private delegate bool get_newLoopDelegate(IntPtr @this);

		// Token: 0x0200004A RID: 74
		// (Invoke) Token: 0x060001B0 RID: 432
		private delegate VFXSpawnerLoopState get_loopStateDelegate(IntPtr @this);

		// Token: 0x0200004B RID: 75
		// (Invoke) Token: 0x060001B2 RID: 434
		private delegate void set_loopStateDelegate(IntPtr @this, VFXSpawnerLoopState value);

		// Token: 0x0200004C RID: 76
		// (Invoke) Token: 0x060001B4 RID: 436
		private delegate float get_spawnCountDelegate(IntPtr @this);

		// Token: 0x0200004D RID: 77
		// (Invoke) Token: 0x060001B6 RID: 438
		private delegate void set_spawnCountDelegate(IntPtr @this, float value);

		// Token: 0x0200004E RID: 78
		// (Invoke) Token: 0x060001B8 RID: 440
		private delegate float get_deltaTimeDelegate(IntPtr @this);

		// Token: 0x0200004F RID: 79
		// (Invoke) Token: 0x060001BA RID: 442
		private delegate void set_deltaTimeDelegate(IntPtr @this, float value);

		// Token: 0x02000050 RID: 80
		// (Invoke) Token: 0x060001BC RID: 444
		private delegate float get_totalTimeDelegate(IntPtr @this);

		// Token: 0x02000051 RID: 81
		// (Invoke) Token: 0x060001BE RID: 446
		private delegate void set_totalTimeDelegate(IntPtr @this, float value);

		// Token: 0x02000052 RID: 82
		// (Invoke) Token: 0x060001C0 RID: 448
		private delegate float get_delayBeforeLoopDelegate(IntPtr @this);

		// Token: 0x02000053 RID: 83
		// (Invoke) Token: 0x060001C2 RID: 450
		private delegate void set_delayBeforeLoopDelegate(IntPtr @this, float value);

		// Token: 0x02000054 RID: 84
		// (Invoke) Token: 0x060001C4 RID: 452
		private delegate float get_loopDurationDelegate(IntPtr @this);

		// Token: 0x02000055 RID: 85
		// (Invoke) Token: 0x060001C6 RID: 454
		private delegate void set_loopDurationDelegate(IntPtr @this, float value);

		// Token: 0x02000056 RID: 86
		// (Invoke) Token: 0x060001C8 RID: 456
		private delegate float get_delayAfterLoopDelegate(IntPtr @this);

		// Token: 0x02000057 RID: 87
		// (Invoke) Token: 0x060001CA RID: 458
		private delegate void set_delayAfterLoopDelegate(IntPtr @this, float value);

		// Token: 0x02000058 RID: 88
		// (Invoke) Token: 0x060001CC RID: 460
		private delegate int get_loopIndexDelegate(IntPtr @this);

		// Token: 0x02000059 RID: 89
		// (Invoke) Token: 0x060001CE RID: 462
		private delegate void set_loopIndexDelegate(IntPtr @this, int value);

		// Token: 0x0200005A RID: 90
		// (Invoke) Token: 0x060001D0 RID: 464
		private delegate int get_loopCountDelegate(IntPtr @this);

		// Token: 0x0200005B RID: 91
		// (Invoke) Token: 0x060001D2 RID: 466
		private delegate void set_loopCountDelegate(IntPtr @this, int value);

		// Token: 0x0200005C RID: 92
		// (Invoke) Token: 0x060001D4 RID: 468
		private delegate IntPtr get_vfxEventAttributeDelegate(IntPtr @this);
	}
}
