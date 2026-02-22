using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000013 RID: 19
	public class GUIStateObjects : Object
	{
		// Token: 0x06000350 RID: 848 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		// Note: this type is marked as 'beforefieldinit'.
		static GUIStateObjects()
		{
			Il2CppClassPointerStore<GUIStateObjects>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.IMGUIModule.dll", "UnityEngine", "GUIStateObjects");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GUIStateObjects>.NativeClassPtr);
			GUIStateObjects.NativeFieldInfoPtr_s_StateCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GUIStateObjects>.NativeClassPtr, "s_StateCache");
			GUIStateObjects.NativeMethodInfoPtr_GetStateObject_Internal_Static_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GUIStateObjects>.NativeClassPtr, 100663549);
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0000DF40 File Offset: 0x0000C140
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 87050, XrefRangeEnd = 87065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetStateObject(Type t, int controlID)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref controlID;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GUIStateObjects.NativeMethodInfoPtr_GetStateObject_Internal_Static_Object_Type_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00003538 File Offset: 0x00001738
		public GUIStateObjects(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000353 RID: 851 RVA: 0x0000DF94 File Offset: 0x0000C194
		// (set) Token: 0x06000354 RID: 852 RVA: 0x00003541 File Offset: 0x00001741
		public unsafe static Dictionary<int, Object> s_StateCache
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GUIStateObjects.NativeFieldInfoPtr_s_StateCache, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<int, Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GUIStateObjects.NativeFieldInfoPtr_s_StateCache, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000DFBC File Offset: 0x0000C1BC
		public static Object QueryStateObject(Type t, int controlID)
		{
			Object @object = GUIStateObjects.s_StateCache[controlID];
			bool flag = t.IsInstanceOfType(@object);
			Object object2;
			if (flag)
			{
				object2 = @object;
			}
			else
			{
				object2 = null;
			}
			return object2;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00003553 File Offset: 0x00001753
		public static void Tests_ClearObjects()
		{
			GUIStateObjects.s_StateCache.Clear();
		}

		// Token: 0x040001A6 RID: 422
		private static readonly IntPtr NativeFieldInfoPtr_s_StateCache;

		// Token: 0x040001A7 RID: 423
		private static readonly IntPtr NativeMethodInfoPtr_GetStateObject_Internal_Static_Object_Type_Int32_0;
	}
}
