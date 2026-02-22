using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Events
{
	// Token: 0x02000104 RID: 260
	[Serializable]
	public class PersistentCallGroup : Object
	{
		// Token: 0x060015BB RID: 5563 RVA: 0x00052BF0 File Offset: 0x00050DF0
		// Note: this type is marked as 'beforefieldinit'.
		static PersistentCallGroup()
		{
			Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "PersistentCallGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr);
			PersistentCallGroup.NativeFieldInfoPtr_m_Calls = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, "m_Calls");
			PersistentCallGroup.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100664908);
			PersistentCallGroup.NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr, 100664909);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00052C5C File Offset: 0x00050E5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 80378, RefRangeEnd = 80380, XrefRangeStart = 80371, XrefRangeEnd = 80378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PersistentCallGroup()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PersistentCallGroup>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCallGroup.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x00052C98 File Offset: 0x00050E98
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 80397, RefRangeEnd = 80400, XrefRangeStart = 80380, XrefRangeEnd = 80397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Initialize(InvokableCallList invokableList, UnityEventBase unityEventBase)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(invokableList);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(unityEventBase);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PersistentCallGroup.NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x0000C629 File Offset: 0x0000A829
		public PersistentCallGroup(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x060015BF RID: 5567 RVA: 0x00052CEC File Offset: 0x00050EEC
		// (set) Token: 0x060015C0 RID: 5568 RVA: 0x0000C632 File Offset: 0x0000A832
		public unsafe List<PersistentCall> m_Calls
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCallGroup.NativeFieldInfoPtr_m_Calls);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PersistentCall>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PersistentCallGroup.NativeFieldInfoPtr_m_Calls), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00052D1C File Offset: 0x00050F1C
		public int Count
		{
			get
			{
				return this.m_Calls.Count;
			}
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x00052D3C File Offset: 0x00050F3C
		public PersistentCall GetListener(int index)
		{
			return this.m_Calls[index];
		}

		// Token: 0x060015C3 RID: 5571 RVA: 0x00052D5C File Offset: 0x00050F5C
		public IEnumerable<PersistentCall> GetListeners()
		{
			return this.m_Calls;
		}

		// Token: 0x060015C4 RID: 5572 RVA: 0x0000C651 File Offset: 0x0000A851
		public void AddListener()
		{
			this.m_Calls.Add(new PersistentCall());
		}

		// Token: 0x060015C5 RID: 5573 RVA: 0x0000C665 File Offset: 0x0000A865
		public void AddListener(PersistentCall call)
		{
			this.m_Calls.Add(call);
		}

		// Token: 0x060015C6 RID: 5574 RVA: 0x0000C675 File Offset: 0x0000A875
		public void RemoveListener(int index)
		{
			this.m_Calls.RemoveAt(index);
		}

		// Token: 0x060015C7 RID: 5575 RVA: 0x0000C685 File Offset: 0x0000A885
		public void Clear()
		{
			this.m_Calls.Clear();
		}

		// Token: 0x060015C8 RID: 5576 RVA: 0x00052D74 File Offset: 0x00050F74
		public void RegisterEventPersistentListener(int index, Object targetObj, Type targetObjType, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.EventDefined;
		}

		// Token: 0x060015C9 RID: 5577 RVA: 0x00052DA0 File Offset: 0x00050FA0
		public void RegisterVoidPersistentListener(int index, Object targetObj, Type targetObjType, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Void;
		}

		// Token: 0x060015CA RID: 5578 RVA: 0x00052DCC File Offset: 0x00050FCC
		public void RegisterObjectPersistentListener(int index, Object targetObj, Type targetObjType, Object argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Object;
			listener.arguments.unityObjectArgument = argument;
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00052E04 File Offset: 0x00051004
		public void RegisterIntPersistentListener(int index, Object targetObj, Type targetObjType, int argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Int;
			listener.arguments.intArgument = argument;
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x00052E3C File Offset: 0x0005103C
		public void RegisterFloatPersistentListener(int index, Object targetObj, Type targetObjType, float argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Float;
			listener.arguments.floatArgument = argument;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00052E74 File Offset: 0x00051074
		public void RegisterStringPersistentListener(int index, Object targetObj, Type targetObjType, string argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.String;
			listener.arguments.stringArgument = argument;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00052EAC File Offset: 0x000510AC
		public void RegisterBoolPersistentListener(int index, Object targetObj, Type targetObjType, bool argument, string methodName)
		{
			PersistentCall listener = this.GetListener(index);
			listener.RegisterPersistentListener(targetObj, targetObjType, methodName);
			listener.mode = PersistentListenerMode.Bool;
			listener.arguments.boolArgument = argument;
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00052EE4 File Offset: 0x000510E4
		public void UnregisterPersistentListener(int index)
		{
			PersistentCall listener = this.GetListener(index);
			listener.UnregisterPersistentListener();
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00052F04 File Offset: 0x00051104
		public void RemoveListeners(Object target, string methodName)
		{
			List<PersistentCall> list = new List<PersistentCall>();
			for (int i = 0; i < this.m_Calls.Count; i++)
			{
				bool flag = this.m_Calls[i].target == target && this.m_Calls[i].methodName == methodName;
				if (flag)
				{
					list.Add(this.m_Calls[i]);
				}
			}
			this.m_Calls.RemoveAll(new Predicate<PersistentCall>(list.Contains));
		}

		// Token: 0x04001020 RID: 4128
		private static readonly IntPtr NativeFieldInfoPtr_m_Calls;

		// Token: 0x04001021 RID: 4129
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001022 RID: 4130
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Void_InvokableCallList_UnityEventBase_0;
	}
}
