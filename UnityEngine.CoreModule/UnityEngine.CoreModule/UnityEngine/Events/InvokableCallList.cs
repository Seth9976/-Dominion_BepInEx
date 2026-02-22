using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x02000105 RID: 261
	public class InvokableCallList : Object
	{
		// Token: 0x060015D1 RID: 5585 RVA: 0x00052F98 File Offset: 0x00051198
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCallList()
		{
			Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCallList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr);
			InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_PersistentCalls");
			InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_RuntimeCalls");
			InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_ExecutingCalls");
			InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, "m_NeedsUpdate");
			InvokableCallList.NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100664910);
			InvokableCallList.NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100664911);
			InvokableCallList.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100664912);
			InvokableCallList.NativeMethodInfoPtr_ClearPersistent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100664913);
			InvokableCallList.NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100664914);
			InvokableCallList.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr, 100664915);
		}

		// Token: 0x060015D2 RID: 5586 RVA: 0x00053090 File Offset: 0x00051290
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80403, RefRangeEnd = 80404, XrefRangeStart = 80400, XrefRangeEnd = 80403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPersistentInvokableCall(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D3 RID: 5587 RVA: 0x000530D4 File Offset: 0x000512D4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80407, RefRangeEnd = 80409, XrefRangeStart = 80404, XrefRangeEnd = 80407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddListener(BaseInvokableCall call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060015D4 RID: 5588 RVA: 0x00053118 File Offset: 0x00051318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80433, RefRangeEnd = 80434, XrefRangeStart = 80409, XrefRangeEnd = 80433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveListener(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x0005316C File Offset: 0x0005136C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80437, RefRangeEnd = 80440, XrefRangeStart = 80434, XrefRangeEnd = 80437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearPersistent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_ClearPersistent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x000531A0 File Offset: 0x000513A0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80448, RefRangeEnd = 80450, XrefRangeStart = 80440, XrefRangeEnd = 80448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<BaseInvokableCall> PrepareInvoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr3) : null;
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x000531E0 File Offset: 0x000513E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80465, RefRangeEnd = 80467, XrefRangeStart = 80450, XrefRangeEnd = 80465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCallList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCallList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCallList.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x0000C694 File Offset: 0x0000A894
		public InvokableCallList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x0005321C File Offset: 0x0005141C
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x0000C69D File Offset: 0x0000A89D
		public unsafe List<BaseInvokableCall> m_PersistentCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_PersistentCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x0005324C File Offset: 0x0005144C
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x0000C6BC File Offset: 0x0000A8BC
		public unsafe List<BaseInvokableCall> m_RuntimeCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_RuntimeCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x0005327C File Offset: 0x0005147C
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x0000C6DB File Offset: 0x0000A8DB
		public unsafe List<BaseInvokableCall> m_ExecutingCalls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BaseInvokableCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_ExecutingCalls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x000532AC File Offset: 0x000514AC
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x0000C6FA File Offset: 0x0000A8FA
		public unsafe bool m_NeedsUpdate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCallList.NativeFieldInfoPtr_m_NeedsUpdate)) = value;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x000532D4 File Offset: 0x000514D4
		public int Count
		{
			get
			{
				return this.m_PersistentCalls.Count + this.m_RuntimeCalls.Count;
			}
		}

		// Token: 0x060015E2 RID: 5602 RVA: 0x0000C715 File Offset: 0x0000A915
		public void Clear()
		{
			this.m_RuntimeCalls.Clear();
			this.m_NeedsUpdate = true;
		}

		// Token: 0x04001023 RID: 4131
		private static readonly IntPtr NativeFieldInfoPtr_m_PersistentCalls;

		// Token: 0x04001024 RID: 4132
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimeCalls;

		// Token: 0x04001025 RID: 4133
		private static readonly IntPtr NativeFieldInfoPtr_m_ExecutingCalls;

		// Token: 0x04001026 RID: 4134
		private static readonly IntPtr NativeFieldInfoPtr_m_NeedsUpdate;

		// Token: 0x04001027 RID: 4135
		private static readonly IntPtr NativeMethodInfoPtr_AddPersistentInvokableCall_Public_Void_BaseInvokableCall_0;

		// Token: 0x04001028 RID: 4136
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Void_BaseInvokableCall_0;

		// Token: 0x04001029 RID: 4137
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Void_Object_MethodInfo_0;

		// Token: 0x0400102A RID: 4138
		private static readonly IntPtr NativeMethodInfoPtr_ClearPersistent_Public_Void_0;

		// Token: 0x0400102B RID: 4139
		private static readonly IntPtr NativeMethodInfoPtr_PrepareInvoke_Public_List_1_BaseInvokableCall_0;

		// Token: 0x0400102C RID: 4140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
