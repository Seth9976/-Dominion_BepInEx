using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.UIElements
{
	// Token: 0x02000055 RID: 85
	public class CommandEventBase<T> : EventBase<T> where T : CommandEventBase<T>, new()
	{
		// Token: 0x06000545 RID: 1349 RVA: 0x0001C244 File Offset: 0x0001A444
		// Note: this type is marked as 'beforefieldinit'.
		static CommandEventBase()
		{
			Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "CommandEventBase`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr);
			CommandEventBase<T>.NativeFieldInfoPtr_m_CommandName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, "m_CommandName");
			CommandEventBase<T>.NativeMethodInfoPtr_set_commandName_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100663701);
			CommandEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100663702);
			CommandEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100663703);
			CommandEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100663704);
			CommandEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr, 100663705);
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0001C480 File Offset: 0x0001A680
		// (set) Token: 0x06000546 RID: 1350 RVA: 0x0001C328 File Offset: 0x0001A528
		public unsafe string commandName
		{
			get
			{
				bool flag = this.m_CommandName == null && base.imguiEvent != null;
				string text;
				if (flag)
				{
					text = base.imguiEvent.commandName;
				}
				else
				{
					text = this.m_CommandName;
				}
				return text;
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr_set_commandName_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x0001C36C File Offset: 0x0001A56C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 93528, RefRangeEnd = 93542, XrefRangeStart = 93528, XrefRangeEnd = 93542, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CommandEventBase<T>.NativeMethodInfoPtr_Init_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x0001C3A8 File Offset: 0x0001A5A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93608, XrefRangeEnd = 93609, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public new unsafe void LocalInit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr_LocalInit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x0001C3DC File Offset: 0x0001A5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 93609, XrefRangeEnd = 93620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetPooled(Event systemEvent)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(systemEvent);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x0001C41C File Offset: 0x0001A61C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 93673, RefRangeEnd = 93675, XrefRangeStart = 93620, XrefRangeEnd = 93673, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CommandEventBase()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CommandEventBase<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CommandEventBase<T>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x0000483B File Offset: 0x00002A3B
		public CommandEventBase(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0001C458 File Offset: 0x0001A658
		// (set) Token: 0x0600054D RID: 1357 RVA: 0x00004844 File Offset: 0x00002A44
		public unsafe string m_CommandName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandEventBase<T>.NativeFieldInfoPtr_m_CommandName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CommandEventBase<T>.NativeFieldInfoPtr_m_CommandName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		public static T GetPooled(string commandName)
		{
			T pooled = EventBase<T>.GetPooled();
			pooled.commandName = commandName;
			return pooled;
		}

		// Token: 0x040002B7 RID: 695
		private static readonly IntPtr NativeFieldInfoPtr_m_CommandName;

		// Token: 0x040002B8 RID: 696
		private static readonly IntPtr NativeMethodInfoPtr_set_commandName_Protected_set_Void_String_0;

		// Token: 0x040002B9 RID: 697
		private static readonly IntPtr NativeMethodInfoPtr_Init_Protected_Virtual_Void_0;

		// Token: 0x040002BA RID: 698
		private static readonly IntPtr NativeMethodInfoPtr_LocalInit_Private_Void_0;

		// Token: 0x040002BB RID: 699
		private static readonly IntPtr NativeMethodInfoPtr_GetPooled_Public_Static_T_Event_0;

		// Token: 0x040002BC RID: 700
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
