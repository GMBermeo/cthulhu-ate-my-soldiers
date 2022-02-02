using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Text;

/**
 * <b>Highscore</b><br/>
 * This class is only instantiated from within the org.gamejolt.* package.
 * 
 * @author Ashley Gwinnell
 * @since 0.96
 * @version 0.96
 */
public class Highscore  
{
	/** The Highscore properties */
	private Dictionary<string, string> properties;

	/**
	 * Create a new Highscore.
	 */
	public Highscore() {
		properties = new Dictionary<string, string>();
	}
	
	/**
	 * Adds a property to the Highscore.
	 * @param key The key by which the property can be accessed.
	 * @param value The value for the key.
	 */
	public void addProperty(string key, string value) {
		properties[key] = value;
	}
	
	/**
	 * Gets a property of the Highscore that isn't specified by a specific method.
	 * This exists for forward compatibility.
	 * @param key The key of the Highscore attribute you want to obtain.
	 * @return A property of the Highscore that isn't specified by a specific method.
	 */
	public string getProperty(string key) {
		return properties[key];
	}
	
	/**
	 * Retrieve the string value associated with the highscore. e.g. "5 Grapefruits".
	 * @return the string value associated with the highscore. e.g. "5 Grapefruits".
	 */
	public string getScorestring() {
		try {
			//return URLDecoder.decode(properties.get("score"), "UTF-8");
			return WWW.UnEscapeURL(properties["score"]);
		} catch (Exception e) {
			Debug.Log("GJAPI WARNING: " + e.Message);
			return properties["score"];
		}
	}
	
	/**
	 * Retrieve the integer value associated with the highscore. e.g. 5.
	 * @return the integer value associated with the highscore. e.g. 5.
	 */
	public int getScoreValue() {
		return Int32.Parse(properties["sort"]); //Integer.parseInt(properties.get("sort"));
	}
	
	/**
	 * Retrieve the extra data associated with the highscore; usually JSON, XML or a serialised string.
	 * @return the extra data associated with the highscore.
	 */
	public string getExtraData() {
		try {
			//return URLDecoder.decode(properties.get("extra_data"), "UTF-8");
			return WWW.UnEscapeURL(properties["extra_data"]);
		} catch(Exception e) {
			Debug.Log("GJAPI WARNING: " + e.Message);
			return properties["extra_data"];
		}
	}
	
	/**
	 * Retrieve whether the Highscore was submitted by a Guest or not.
	 * @return true if the Highscore was submitted by a Guest, otherwise false.
	 */
	public bool isGuestHighscore() {
		return (this.properties["guest"].Length > 0);
	}
	
	/**
	 * Retrieve whether the Highscore was submitted by a User or not.
	 * @return true if the Highscore was submitted by a User, otherwise false.
	 */
	public bool isUserHighscore() {
		return !this.isGuestHighscore();
	}
	
	/**
	 * Retrieve the time that the highscore was submitted.
	 * @return The time that the highscore was submitted.
	 */
	public string getTime() {
		return this.properties["stored"];
	}
	
	/**
	 * Retrieve the User ID of the User that submitted the highscore. 
	 * @return The User ID of the User that submitted the highscore. 
	 */
	public int getUserId() {
		if (properties["user_id"].Length==0) {
			return -1;
		}
		return Int32.Parse(properties["user_id"]); //Integer.parseInt(properties.get("user_id"));
	}
	
	public override string ToString() {
		StringBuilder b = new StringBuilder();
		b.Append("Highscore [user_id=");
		b.Append(this.getUserId());
		b.Append(", score=");
		b.Append(this.getScorestring());
		b.Append("]");
		return b.ToString();
	}
}